using Microsoft.Extensions.DependencyInjection;
using warehouse_management.App.Interfaces;
using warehouse_management.App.Services;
using warehouse_management.Data;
using warehouse_management.UI;

namespace warehouse_management
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

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
            var login = serviceProvider.GetRequiredService<LoginForm>();
            Application.Run(login);
            }
        }

        static void ConfigureServices(IServiceCollection services)
        {
            // Register your DbContext with sensitive data logging enabled
            services.AddDbContext<WdbContext>(options =>
            {
                options.EnableSensitiveDataLogging();
            });

            // Register your forms
            services.AddScoped<Form1>();
            services.AddScoped<LoginForm>();

            // Register your services
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<IAuthService, AuthService>();
        }
    }
}