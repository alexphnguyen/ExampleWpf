
namespace DataModel {
  public class HorseModel {
    public string Name { get; set; }
    public int Legs { get; set; }
    public bool Useful { get { return Legs == 4; } }
  }
}