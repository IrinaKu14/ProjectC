using ProjectC.Applications.Desktop.AdminPanel;
using ProjectC.Applications.Desktop.AdminPanel.ViewModels;
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
        protected override void OnStartup(StartupEventArgs e)
        {
            //LoginNewWindow window = new LoginNewWindow(new LoginNewViewModel());
            //LoginWindow window = new LoginWindow(new LoginViewModel());
            LoginWindow window = new LoginWindow(new LoginNewViewModel()); //новая логика
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();

        }
    }

}
