
namespace ViewModel {
  /// <summary>
  /// These are the values that will have "Bindings" in MainWindow.
  /// Bindings mean that when these properties change and PropertyChanged is called,
  /// the values in the View will also change.
  /// </summary>
  public class MainWindowViewModel : ViewModelBase {
    public MainWindowViewModel() {

    }
    public string Name { get; set; }
    public int Legs { get; set; }
    public bool Useful { get; set; }
  }
}