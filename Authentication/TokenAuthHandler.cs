
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Text.Json;
using VroomWiki.Data;
using VroomWiki.Models;

namespace Backend_Webshop.Authentication
{
    public class TokenAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private double expirationInMinutes = 5;
        private readonly IConfiguration configuration;
        private AppDbContext appContext;

        public TokenAuthHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            AppDbContext appContext,
            IConfiguration configuration) : base(options, logger, encoder)
        {
            this.configuration = configuration;
            this.appContext = appContext;
            try
            {
                this.expirationInMinutes = double.Parse(configuration.GetSection("authConfig").GetSection("expirationInMinutes").Value);
            }
            catch { }
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var authorizationHeader = Context.Request.Headers["Authorization"];
            if (!authorizationHeader.Any())
                return await Task.FromResult(AuthenticateResult.NoResult());

            var tokenString = authorizationHeader.ToString();

            
            return await HandleToken(tokenString);
        }

        private async Task<AuthenticateResult> HandleToken(string tokenString)
        {
            var session = appContext.Set<SessionModel>().Include(s => s.User).SingleOrDefault(s => s.Token == tokenString);
            if (session != null && session.LastAccess.AddMinutes(expirationInMinutes) > DateTime.UtcNow)
            {
                session.LastAccess = DateTime.UtcNow;
                appContext.Entry(session).State = EntityState.Modified;
                appContext.SaveChanges();

                var roles = appContext.Set<UserRoleModel>()
                                      .Include(r => r.Role)
                                      .Where(r => r.UserId == session.User.Id)
                                      .Select(r => r.Role.Name);
                
                var claims = roles.Select(r => new Claim(ClaimTypes.Role, r)).ToList();
                claims.Add(new Claim("UserId", session.User.Id.ToString()));
                
                claims.Add(new Claim("Email", session.User.Email));
                claims.Add(new Claim("Token", tokenString));
                claims.Add(new Claim("ValidTo", DateTime.Now.AddMinutes(expirationInMinutes).ToString()));

                var claimsIdentity = new ClaimsIdentity(claims, Scheme.Name);
                var ticket = new AuthenticationTicket(new ClaimsPrincipal(claimsIdentity), new AuthenticationProperties(), Scheme.Name);
                Context.Response.Headers.Add("session", JsonSerializer.Serialize(new
                {
                    token = session.Token,
                    userId = session.User.Id,
                    
                    validTo = DateTime.Now.AddMinutes(expirationInMinutes),
                    roles = roles
                }));
                //Context.Response.Headers.Add("Access-Control-Expose-Headers", "session");

                return await Task.FromResult(AuthenticateResult.Success(ticket));
            }
            else
            {
                return await Task.FromResult(AuthenticateResult.Fail("Sikertelen authentikáció"));
            }
        }
    }
}
