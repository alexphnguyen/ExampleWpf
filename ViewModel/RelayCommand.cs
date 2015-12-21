using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel {
  public class RelayCommand : ICommand {

    private readonly Action<object> _action;
    private readonly Func<object, bool> _canExecute;

    public RelayCommand(Action<object> action, Func<object, bool> canExecute) {
      _action = action;
      _canExecute = canExecute;
    }

    public bool CanExecute(object parameter) {
      return _canExecute(parameter);
    }

    public event EventHandler CanExecuteChanged {
      add { CommandManager.RequerySuggested += value; }
      remove { CommandManager.RequerySuggested -= value; }
    }

    public void Execute(object parameter) {
      _action(parameter);
    }
  }

  public class RelayCommand<T> : ICommand {

    private readonly Action<object> _action;
    private readonly Func<object, bool> _canExecute;

    public RelayCommand(Action<object> action) {
      _action = action;
      _canExecute = x => true;
    }

    public RelayCommand(Action<object> action, Func<object, bool> canExecute)
      : this(action) {
      _canExecute = canExecute;
    }

    public bool CanExecute(object parameter) {
      return _canExecute(parameter);
    }

    public event EventHandler CanExecuteChanged;

    public void Execute(object parameter) {
      _action(parameter);
    }

  }
}
