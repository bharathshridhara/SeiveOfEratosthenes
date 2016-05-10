using System;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace FindPrimes.Base
{
    public class RelayCommand : ICommand
    {

        Action<object> _executableMethod;
        Predicate<object> _canExecute;

        public RelayCommand(Action<object> Execute)
        {
            _executableMethod = Execute;
            _canExecute = ((x) => true);
        }

        public RelayCommand(Action<object> Execute, Predicate<object> CanExecute)
        {
            _executableMethod = Execute;
            _canExecute = CanExecute;
        }
        
        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged = delegate { };
        

        public void Execute(object MethodParameter)
        {
            _executableMethod(MethodParameter);
        }

        
    }
    
}
