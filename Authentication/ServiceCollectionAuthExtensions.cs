using Microsoft.AspNetCore.Authentication;

namespace VroomWiki.Authentication
{
    public static class ServiceCollectionAuthExtensions
    {

        public static IServiceCollection AddTokenAuthentication(this IServiceCollection services, IConfiguration config)
        {

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = "TokenAuthentication";

            }).AddScheme<AuthenticationSchemeOptions, TokenAuthHandler>("TokenAuthentication", options => { });

            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("RedisToken", policy => policy.RequireClaim("RedisToken"));
            //    options.AddPolicy("JwtToken", policy => policy.RequireClaim("JwtToken"));
            //});

            services.AddAuthorization(options => { });
            return services;

        }
    }
}
