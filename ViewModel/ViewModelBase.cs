using System.ComponentModel;

namespace ViewModel {
  /// <summary>
  /// Allows access to PropertyChanged from all ViewModels.
  /// PropertyChanged tells the View when the ViewModel property has changed.
  /// For example, in the Detail, if the underlying Name property changes, 
  /// the PropertyChanged will refresh the View and get the new value.
  /// </summary>
  public abstract class ViewModelBase : INotifyPropertyChanged {

    public event PropertyChangedEventHandler PropertyChanged;

    protected void NotifyPropertyChanged(string info) {
      if (PropertyChanged != null) {
        PropertyChanged(this, new PropertyChangedEventArgs(info));
      }
    }
  }
}