using Microsoft.Extensions.DependencyInjection;

namespace BenfCompalintWeb.Areas.AdminService.Service
{
    public static class AdminStartup
    {
        public static IServiceCollection AddAdminServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
