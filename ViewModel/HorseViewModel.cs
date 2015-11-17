using BusinessModel;

namespace ViewModel {

  /// <summary>
  /// This layer will hold properties specific to the view,
  /// including things like IsSelected, IsExpanded (for trees), and IsFocused.
  /// </summary>
  public class HorseViewModel {
    public HorseViewModel(HorseModel hm) {
      Model = hm;
    }

    /*
     * The ViewModel is a window to the underlying Model.
     * It only exposes the parts of the model that will appear in the view,
     * which it does via these "pass-through" properties.
     */
    private HorseModel Model { get; set; }

    public string Name {
      get { return Model.Name; }
      set { Model.Name = value; }
    }

    public int Legs {
      get { return Model.Legs; }
      set { Model.Legs = value; }
    }

    public bool Useful {
      get { return Model.Useful; }
    }
  }
}