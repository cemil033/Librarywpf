using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Library.Data.Repos;
using Library.Models.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library.Logic.ViewModels
{
    public class RegisterViewModel:ViewModelBase
    {
        private readonly IRepository<User> _userRepository;

        public RegisterViewModel(IRepository<User> repository)
        {
            _userRepository = repository;            
            
        }

        private string username;
        public string Username { get => username; set {
                username = value;
                RaisePropertyChanged();
            } }


        private string password;
        public string Password
        {
            get => password; set
            {
                password = value;
                RaisePropertyChanged();
            }
        }


        private string firstName;
        public string FirstName
        {
            get => firstName; set
            {
                firstName = value;
                RaisePropertyChanged();
            }
        }


        private string lastName;
        public string LastName { get => lastName;set 
            { 
                lastName = value;
                RaisePropertyChanged();
            } }

        public RelayCommand registercommand { get => new RelayCommand(
            () =>
            {
                if (_userRepository.GetAll().FirstOrDefault(t => t.UserName == username) == null)
                {
                    _userRepository.Add(new User() { UserName = username, Password = password, FirstName = firstName, LastName = lastName });
                    _userRepository.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Username taken");
                }
            }
            );
        }

    }
}
