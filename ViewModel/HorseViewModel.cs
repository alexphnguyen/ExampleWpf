using DataModel;
namespace ViewModel {

  /// <summary>
  /// This layer will hold properties specific to the view,
  /// including things like IsSelected, IsExpanded (for trees), and IsFocused.
  /// </summary>
  public class HorseViewModel {
    public HorseViewModel(HorseModel hm) {
      _model = hm;
    }

    /*
     * The ViewModel is a window to the underlying Model.
     * It only exposes the parts of the model that will appear in the view,
     * which it does via these "pass-through" properties.
     */
    private HorseModel _model { get; set; }

    public string Name {
      get { return _model.Name; }
      set { _model.Name = value; }
    }

    public int Legs {
      get { return _model.Legs; }
      set { _model.Legs = value; }
    }

    public bool Useful {
      get { return _model.Useful; }
    }
  }
}