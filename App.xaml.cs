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
using SandpitWPF.Services;

namespace SandpitWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IContainer _container { get; set; }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Init();
            using (var scope = _container.BeginLifetimeScope())
            {
                Current.MainWindow = new MainWindow
                {
                    DataContext = scope.Resolve<MainViewModel>()
                };
                Current.MainWindow.Show();
            }

            //Before Dependency injection
            //Current.MainWindow = new MainWindow { DataContext = new MainViewModel() };
            //Current.MainWindow.Show();
        }

        private static void Init()
        {
            var builder = new ContainerBuilder();
            //Class First Interface second! 
            builder.RegisterType<ConversionsViewModel>().As<IConversionsViewModel>();
            builder.RegisterType<BasicConversionViewModel>().As<IBasicConversionViewModel>();
            builder.RegisterType<BasicDataBindingViewModel>().As<IBasicDataBindingViewModel>();
            builder.RegisterType<CheckBoxViewModelcs>().As<ICheckBoxViewModelcs>();
            builder.RegisterType<UserViewModel>().As<IUserViewModel>();
            builder.RegisterType<BasicConversionService>().As<IBasicConversionService>();
            builder.RegisterType<BasicDataBindingService>().As<IBasicDataBindingService>();
            //builder.RegisterType<>().As<>();
            builder.RegisterType<MainViewModel>();
            _container = builder.Build();

        }
    }
}
