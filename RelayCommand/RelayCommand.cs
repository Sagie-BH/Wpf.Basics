using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfRelayCommand
{
    public class RelayCommand : ICommand
    {
        readonly Action<object> _exeucte;
        readonly Predicate<object> _canExeute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute) 
        {
            if (execute == null)
                throw new NullReferenceException("execute");

            _exeucte = execute;
            _canExeute = canExecute;
        }

        public RelayCommand(Action<object> execute) : this(execute,null)
        {

        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            // Sometimes there is no need for check
            return _canExeute == null ? true : _canExeute(parameter);
        }

        public void Execute(object parameter)
        {
            _exeucte.Invoke(parameter);
        }
    }
}
