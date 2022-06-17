using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library.Logic.Commands
{
    public class MyRelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value;}
        }
        private Action<Object> execute;
        private Predicate<Object> canExecute;

        public MyRelayCommand(Action<object> execute,Predicate<object> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter) => canExecute == null || canExecute(parameter);
        

        public void Execute(object? parameter)=>execute.Invoke(parameter);
        
    }
}
