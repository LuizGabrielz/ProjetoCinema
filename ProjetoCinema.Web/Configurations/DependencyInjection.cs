using ProjetoCinema.Core.Settings;
using ProjetoCinema.Data;
using ProjetoCinema.Data.Repositories;
using Core.Interfaces.Repositories;
using ProjetoCinema.Core.Helpers;

namespace ProjetoCinema.Web.Configurations
{ 
    public static class DependencyInjection
    {
        public static void AddDependencies(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddSingleton(appSettings);

            services.AddControllersWithViews();

            services.AddScoped<ApplicationDbContext>();

            services.AddScoped<IFilmeRepository, FilmeRepository>();
            
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
           
            services.AddScoped<Notification>();
        }
    }
}       
