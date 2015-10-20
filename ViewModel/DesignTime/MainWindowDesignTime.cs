
namespace ViewModel.DesignTime {
  public class MainWindowDesignTime : MainWindowViewModel {
    public MainWindowDesignTime() {
      /*
       * The purpose of these default values are to populate the design time view.
       * They will not appear at runtime.
       * This allows you to easily style the View,
       * previewing things like font color,
       * botton border size,
       * or the apperance of a selected item in a list.
       */
      Name = "Default Name";
      Legs = 0;
      Useful = false;
    }
  }
}