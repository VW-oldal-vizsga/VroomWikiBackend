using Backend_Webshop.Extensions;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Security.Cryptography;
using System.Text;
using VroomWiki.Data;
using VroomWiki.Models;

namespace VroomWiki.Repositories
{
    public class AuthRepository
    {
        readonly AppDbContext appContext;
        private double expirationInMinutes = 10;

        public AuthRepository(AppDbContext appContext, IConfiguration configuration)
        { 
            this.appContext = appContext;
            try
            {
                this.expirationInMinutes = double.Parse(configuration.GetSection("authConfig").GetSection("expirationInMinutes").Value);
            }
            catch { }
        }

        public dynamic Login(LoginModel? loginModel) 
        {
            string? username = loginModel?.Username.ToString();
            string? email = loginModel?.Email.ToString();
            string? password = loginModel?.Password.ToString();

            if (loginModel  == null || email== null || password == null)
            {
                throw new Exception("Email and password must be provided");
            }

            var user = appContext.Set<User>().SingleOrDefault(x => x.Email == email);
            if (user == null) {return null;}
            if (user.PasswordHash != password.HashPassword())
            {
                return null;
            }

            var token = CreateTokenString(80);

            var session = appContext.Set<SessionModel>().Add(new SessionModel()
            {
                LastAccess = DateTime.Now,
                User = user,
                Token = token
            });
            appContext.SaveChanges();

            return new
            {
                
                validTo = session.Entity.LastAccess.AddMinutes(expirationInMinutes),
                user.Email,
                Roles = appContext.Set<UserRoleModel>()
                                  .Include(r => r.Role)
                                  .Where(r => r.UserId == user.Id)
                                  .Select(r => r.Role.Name),
                Token = token
            };

        }

        public dynamic RegisterUser(User? user)
        {
            if (user == null)
                throw new Exception("User must be provided");

            user.PasswordHash = user.Password.HashPassword();

            appContext.Set<User>().Add(user);
            appContext.SaveChanges();
            appContext.Set<UserRoleModel>().Add(new UserRoleModel() { UserId = user.Id, RoleId = 2 });
            appContext.SaveChanges();
            return Login(new LoginModel() {Username=user.Username, Email = user.Email, Password = user.Password });
        }

        public void Logout(string? tokenString)
        {
            var session = appContext.Set<SessionModel>().Include(s => s.User).SingleOrDefault(s => s.Token == tokenString);
            if (session != null)
            {
                appContext.Set<SessionModel>().Remove(session);
                appContext.SaveChanges();
            }
        }


        private string CreateTokenString(int size)
        {
            char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            byte[] data = new byte[4 * size];
            using (var crypto = RandomNumberGenerator.Create())
                crypto.GetBytes(data);

            StringBuilder result = new StringBuilder(size);
            for (int i = 0; i < size; i++)
            {
                var rnd = BitConverter.ToUInt32(data, i * 4);
                var idx = rnd % chars.Length;

                result.Append(chars[idx]);
            }

            return result.ToString();
        }
    }
}
