using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SandpitWPF.ViewModel;

namespace SandpitWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Current.MainWindow = new MainWindow { DataContext = new MainViewModel() };
            Current.MainWindow.Show();
        }
    }
}
