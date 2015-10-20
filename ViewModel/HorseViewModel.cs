using DataModel;
namespace ViewModel {

  /// <summary>
  /// This layer will hold properties specific to the view,
  /// including things like IsSelected, IsExpanded (for trees), and IsFocused.
  /// </summary>
  public class HorseViewModel {
    public HorseViewModel(HorseModel hm) {
      Model = hm;
    }

    public HorseModel Model { get; set; }

    public string Name { 
      get { return Model.Name; }
      set { Model.Name = value; }
    }
  }
}