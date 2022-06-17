using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Library.Data.Repos;
using Library.Models.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library.Logic.ViewModels
{
    public class BookViewModel:ViewModelBase
    {

        private readonly IRepository<Book> _booksRepository;

        private readonly IRepository<User> _userRepository;

        public User User { get; set; }   

        private List<Book> books;
        public List<Book> Books { get=>books; set { 
                books = value;
                RaisePropertyChanged();
            } }
        public BookViewModel(IRepository<Book> books,IRepository<User> users)
        {
            _booksRepository = books;
            _userRepository = users;
            
        }
       

        private string txtb_search;
        public string Txtb_search { get => txtb_search; set {
                txtb_search = value;
                RaisePropertyChanged();
            } }
        public RelayCommand TextchangedCommand
        {
            get => new RelayCommand(
            () =>
                {
                    Books = _booksRepository.GetAll().Where(t => t.Name.Contains(Txtb_search)).ToList();                    
                });
        }

        private Book selectedBook;
        public Book SelectedBook
        {
            get => selectedBook; set
            {
                selectedBook= value;                
                RaisePropertyChanged();
            }
        }
        public RelayCommand Historycommand
        {
            get => new RelayCommand
            (
                () =>
                {
                    Books=_booksRepository.GetAll().Where(t=>t.user.Contains(User)).ToList();                    
                }
            );
        }
        public RelayCommand ClickTakeCommand
        {
            get => new RelayCommand
            (
                () =>
                {
                    if (selectedBook != null)
                    {
                        SelectedBook.Quantity--;
                        _booksRepository.Update(SelectedBook);
                        _booksRepository.SaveChanges();
                        User.books.Add(SelectedBook);
                        _userRepository.Update(User);
                        _userRepository.SaveChanges();
                        Books = _booksRepository.GetAll().Where(u => u.Quantity > 0 && !u.user.Contains(User)).ToList();
                    }
                }
            );
        }
        public RelayCommand AllCommand
        {
            get => new RelayCommand
                (
                    () =>
                    {
                        Books=_booksRepository.GetAll().Where(u=>u.Quantity>0&& !u.user.Contains(User)).ToList();                        
                    }
                );
        }
    }
}
