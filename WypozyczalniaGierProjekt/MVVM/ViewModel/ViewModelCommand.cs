using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WypozyczalniaGierProjekt.MVVM.ViewModel
{
    public class ViewModelCommand : ICommand
    {
        //Fields
        private readonly Action<object> _executeAction;
        private readonly Predicate<object> _canExecuteAction;

        //Constructors
        public ViewModelCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = null;
        }

        public ViewModelCommand(Action<object> executeAction, Predicate<object> canExecuteAction)
        {
            /// <summary>
            /// The _executeAction holds a delegate to the method that will be executed when the command is executed, while _canExecuteAction holds a delegate to the method that determines whether the command can be executed at a given moment.
            /// </summary>
           
            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        }

        //Events
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value;  }
            remove { CommandManager.RequerySuggested -= value;  }
        }

        //Methods

        /// <summary>
        /// It checks whether the command can be executed at a given moment.
        /// <returns></returns>
        
        public bool CanExecute(object parameter)
        {
            return _canExecuteAction==null ? true : _canExecuteAction(parameter);
        }

        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }
    }
}
