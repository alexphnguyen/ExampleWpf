using Enity;

namespace DataModel {
  public class HorseModel {
    public HorseModel(Horse horse) {
      Load(horse);
    }

    public string Name { get; set; }
    public int Legs { get; set; }
    public bool Useful { get { return Legs == 4; } }

    private void Load(Horse h) {
      this.Name = h.Name;
      this.Legs = h.Legs;
    }
  }
}