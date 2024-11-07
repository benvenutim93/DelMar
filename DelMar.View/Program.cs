using DelMar.DB;
using DelMar.DB.Interfaces;
using DelMar.DB.Repositorios;
using DelMar.DB.UOF;
using DelMar.NET6;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace DelMar.View
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            var form = host.Services.GetRequiredService<FrmMenu>();
            Application.Run(form);
        }

        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
            {
                // Configuración adicional si la necesitas
                config.SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddEnvironmentVariables();
            })
            .ConfigureServices((context, services) =>
            {
                var configuration = context.Configuration;

                #region Context - Unit of Work
                services.AddDbContext<DelMarContext>(opt =>
                    opt.UseSqlServer(configuration.GetConnectionString("pcMari")));

                #endregion

                #region Formularios
                //services.AddTransient<IMyService,MyService>();

                services.AddTransient<FrmMenu>();

                #endregion

                #region Repositorios

                services.AddScoped<IArticulosRepositorio, ArticulosRepositorio>();
                services.AddScoped<ICategoriaRepositorio, CategoriasRepositorio>();
                services.AddScoped<IProveedoresRepositorio, ProveedoresRepositorio>();
                services.AddScoped<IConfiguracionesRepositorio, ConfiguracionesRepositorio>();


                services.AddScoped<IUnitOfWork, UnitOfWork>();
                #endregion
            });
    }
}