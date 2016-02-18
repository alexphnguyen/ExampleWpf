using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Api;
using BusinessModel;

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
        this.Horses = new ObservableCollection<HorseViewModel>(HorseApi.GetAllHorses().Select(hm => new HorseViewModel(hm)).ToList());
    }

    public ObservableCollection<HorseViewModel> Horses { get; set; }

    public ICommand AddHorse {
      get {
        return new RelayCommand(x => this.Horses.Add(new HorseViewModel(new HorseModel() {
          Name = "New Horse",
          Legs = 4,
        })), _ => true);
      }
    }

    public ICommand ClearSelectionCommand {
      get { return new RelayCommand(x => this.SelectedHorse = null, x => this.SelectedHorse != null); }
    }

    public ICommand MouseEnterEventCommand {
      get { return new RelayCommand(o => { HoverText = "Hi mouse!"; }, _ => true); }
    }

    public ICommand MouseLeaveEventCommand {
      get { return new RelayCommand(o => { HoverText = "Bye mouse :("; }, _ => true); }
    }

    private string _hoverText = "Initial Text";
    public string HoverText {
      get { return _hoverText; }
      set {
        _hoverText = value;
        NotifyPropertyChanged("HoverText");
      }
    }

    private HorseViewModel _selectedHorse;
    public HorseViewModel SelectedHorse {
      get { return _selectedHorse; }
      set {
        _selectedHorse = value;
        NotifyPropertyChanged("SelectedHorse");
        NotifyPropertyChanged("ClearSelectionCommand");
      }
    }

  }
}