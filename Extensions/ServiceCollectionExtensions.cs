using BaseAuthenticationWebAPI.Core.Applications.Interfaces.Services;
using BaseAuthenticationWebAPI.Infrastructure.Services;
using BaseAuthenticationWebAPI.Settings;

namespace BaseAuthenticationWebAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureAppSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection("AppSettings:JWT"));
        }

        public static void RegisterSerivces(this IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}