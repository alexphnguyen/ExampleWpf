using System.Collections.Generic;

namespace Enity {
  /// <summary>
  /// Plays the role of the database with some initial data
  /// </summary>
  public static class Horses {

    private List<Horse> _horses = new List<Horse> {
      new Horse{Id=1, Name="Alice"},
      new Horse{Id=2, Name="Bob"},
      new Horse{Id=3, Name="Cryptography"}
    };

    public List<Horse> Horses {
      get { return _horses; }
      set { _horses = value; }
    }
  }
}