using System.Collections.Generic;

namespace Entity {
  /// <summary>
  /// Plays the role of the database with some initial data
  /// </summary>
  public static class HorsesTable {

    private static List<Horse> _horses = new List<Horse> {
      new Horse{Id=1, Legs=4, Name="Alice"},
      new Horse{Id=2, Legs=4, Name="Bob"},
      new Horse{Id=3, Legs=3, Name="Cryptography"}
    };

    public static List<Horse> Horses {
      get { return _horses; }
      set { _horses = value; }
    }
  }
}