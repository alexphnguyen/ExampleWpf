using System.Collections.Generic;
using System.Linq;
using API;

namespace ViewModel {
  /// <summary>
  /// These are the values that will have "Bindings" in MainWindow.
  /// Bindings mean that when these properties change and PropertyChanged is called,
  /// the values in the View will also change.
  /// </summary>
  public class MainWindowViewModel : ViewModelBase {

    /* For the purposes of this example,
     * isDesignTime is used to prevent calls at compile time to our (fake) database.
     * The compiler tries to generate static data for the DesignTime,
     * so it would call the API.
     * With an actual database this would generate a missing ConnectionString error.
     */
    public MainWindowViewModel(bool isDesignTime) {
      if (!isDesignTime)
        this.Horses = HorseAPI.GetAllHorses().Select(hm => new HorseViewModel(hm)).ToList();
    }

    public List<HorseViewModel> Horses { get; set; }

    private HorseViewModel _selectedHorse;

    public HorseViewModel SelectedHorse {
      get { return _selectedHorse; }
      set { 
        _selectedHorse = value;
        NotifyPropertyChanged("SelectedHorse");
      }
    }
    
  }
}