using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Library.Data.Repos;
using Library.Logic.Messages;
using Library.Logic.Services;
using Library.Models.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library.Logic.ViewModels
{
    public class MainViewModel:ViewModelBase
    {
        private readonly IRepository<User> _userRepository;
        private INavigationService navigationService;
        private ViewModelBase currentViewModel;
        public ViewModelBase CurrentViewModel { get => currentViewModel; set =>Set(ref currentViewModel,value); }
        public MainViewModel(IMessenger messenger,INavigationService navigationService,IRepository<User> repository)
        {
            _userRepository=repository;
            this.navigationService = navigationService;
            messenger.Register<NavigationMessage>(this, message =>
            {
                var viewmodel = App.Container.GetInstance(message.ViewModelType) as ViewModelBase;
                CurrentViewModel = viewmodel;
            });
            Col1width = new(640);
            Col2width = new(1280);
        }

        private GridLength col1width;
        public GridLength Col1width { get => col1width; set {
                col1width = value;
                RaisePropertyChanged();
            } }


        private GridLength col2width;
        public GridLength Col2width { get => col2width; set
            {
                col2width = value;
                RaisePropertyChanged();
            }
        }

        public User user { get; set; }

        
        private string username;
        public string Username { get => username; set { 
                username = value;
                RaisePropertyChanged();
            } }

        private string password;
        public string Password { get => password; set { 
                password = value;
                RaisePropertyChanged();
            } }
        
        public RelayCommand loginCommand 
        {

            get => new RelayCommand(() => {
                if (_userRepository.GetAll().FirstOrDefault(e => e.UserName == username && e.Password == password) != null)
                {
                    Col1width = new(0);
                    Col2width = new(1920);
                    user = _userRepository.GetAll().FirstOrDefault(e => e.UserName == username && e.Password == password);
                    navigationService.NavigateTo<BookViewModel>();
                    App.Container.GetInstance<BookViewModel>().User = user;                   
                }
                else
                {
                    MessageBox.Show("Wrong usernaem or password");
                }
            });

        }
        public RelayCommand registerViewCommand
        {
            get => new RelayCommand(() => { navigationService.NavigateTo<RegisterViewModel>(); });

        }
    }
}
