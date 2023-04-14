using ProjetoCinema.Core.Settings;
using ProjetoCinema.Data;

namespace Krita.Web.Configurations
{
    public static class DependencyInjection
    {
        public static void AddDependencies(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddSingleton(appSettings);

            services.AddControllersWithViews();

            services.AddScoped<ApplicationDbContext>();
        }
    }
}
