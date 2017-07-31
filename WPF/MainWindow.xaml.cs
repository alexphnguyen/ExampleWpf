using System;
using System.Deployment.Application;
using System.Windows;
using ViewModel;

namespace WPF {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();

      // An event that will fire when the MainWindow is loaded
      Loaded += MainWindow_Loaded;

      // This connects the View with the ViewModel.
      DataContext = new MainWindowViewModel(false);
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e) {
      // If this is a ClickOnce deployment, append the ClickOnce Revision to the version number (as it gets updated with each publish).
      if (ApplicationDeployment.IsNetworkDeployed)
        DeploymentVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;

      // Display the Version as part of the window title.
      this.Title += " Deployment Version " + DeploymentVersion;
    }

    public Version DeploymentVersion = new Version("0.0");
  }
}
