using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MaterialDesignTest
{
    public class RelayCommand : ICommand
    {
        readonly Action<Object> _execute;
        readonly Predicate<Object> _canExecute;

        public RelayCommand(Action<Object> execute)
            :this(execute, null)
        {

        }
        public RelayCommand(Action<Object> execute, Predicate<Object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentException("execute");
            }
            _execute = execute;
            _canExecute = canExecute;
        }
        
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public void Execute(object parameter) 
        {
            _execute(parameter);
        }




    }
}
