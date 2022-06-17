using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Library.Data;
using Library.Data.Repos;
using Library.Logic.Services;
using Library.Logic.ViewModels;
using Library.Logic.Views;
using Library.Models.Models.Concrete;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Library.Logic
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            Register();
            StartMain<MainViewModel>();
            base.OnStartup(e);
        }
        private void Register()
        {
            Container = new Container();
            Container.RegisterSingleton<INavigationService,NavigationService>();
            Container.RegisterSingleton<IMessenger,Messenger>();
            Container.RegisterSingleton<ApplicationDbContext>();
            Container.RegisterSingleton<IRepository<Book>, Repository<Book>>();
            Container.RegisterSingleton<IRepository<User>, Repository<User>>();
            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<RegisterViewModel>();
            Container.RegisterSingleton<BookViewModel>();
            Container.Verify();
        }
        public void StartMain<T>()where T:ViewModelBase
        {
            Window window = new MainView();
            var viewmodel=Container.GetInstance<T>();
            window.DataContext = viewmodel;
            window.ShowDialog();
        }
    }
}
