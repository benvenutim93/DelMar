using DelMar.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace DelMar.NET6
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            var form = host.Services.GetRequiredService<Form1>();
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

                #region Context
                services.AddDbContext<DelMarContext>(opt =>
                    opt.UseSqlServer(configuration.GetConnectionString("pcMari")));

                #endregion

                #region Formularios
                //services.AddTransient<IMyService,MyService>();

                services.AddTransient<Form1>();

                #endregion

                #region Repositorios

                #endregion
            });
    }
}