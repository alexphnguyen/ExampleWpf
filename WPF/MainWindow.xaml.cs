using System.Windows;
using ViewModel;

namespace WPF {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();

      // This connects the View with the ViewModel.
      DataContext = new MainWindowViewModel(false);
    }
  }
}
