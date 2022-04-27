using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SandpitWPF.ViewModel;
using Autofac;
using IContainer = Autofac.IContainer;
using SandpitWPF.Interfaces;

namespace SandpitWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IContainer Container { get; set; }



        private void Init()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<IConversionsViewModel>().As<ConversionsViewModel>();

        }

        private static void Application_Startup(object sender, StartupEventArgs e)
        {

            Current.MainWindow = new MainWindow { DataContext = new MainViewModel() };
            Current.MainWindow.Show();
        }
    }
}
