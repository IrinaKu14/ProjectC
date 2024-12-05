using Microsoft.Extensions.DependencyInjection;
using ProjectC.Applications.Desktop.AdminPanel;
using ProjectC.Applications.Desktop.AdminPanel.Configuration;
using ProjectC.Applications.Desktop.AdminPanel.ViewModels;
using ProjectC.Applications.Desktop.AdminPanel.ViewModels.Abstract;
using Serilog;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Applications.Desktop.AdminPanel
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _serviceProvider;
        protected override void OnStartup(StartupEventArgs e)
        {
           Log.Logger = new LoggerConfiguration()
                .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Hour, outputTemplate:
                "{Timestamp:yyyy-mm-dd HH:mm:ss. fff zzz} [{level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();
            Log.Logger.Information("test");
            
            
            var services = new ServiceCollection();

            services.AddSerilog(Log.Logger);
            services.AddLogging(opt => opt.AddSerilog(Log.Logger));
           
            services.RegisterViews();
            services.RegisterViewModels();

            services.AddSingleton<ApplicationUser>();

            _serviceProvider = services.BuildServiceProvider();

            var window = _serviceProvider.GetRequiredService<LoginWindow>();  

            //LoginNewWindow window = new LoginNewWindow(new LoginNewViewModel());
            //LoginWindow window = new LoginWindow(new LoginViewModel());
            //LoginWindow window = new LoginWindow(new LoginNewViewModel()); //новая логика
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();

        }

        public void OpenUserWindow()
        {
            _serviceProvider.GetRequiredService<UsersWindow>().Show();
        }
    }

    public class ApplicationUser
    { 
    
        public string Name { get; set; } = Guid.NewGuid().ToString();
    }

}
