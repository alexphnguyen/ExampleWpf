
using System.Collections.Generic;
using DataModel;
using Enity;
using System.Linq;

namespace API {
  public static class HorseAPI {
    public static List<HorseModel> GetAllHorses() {
      return HorsesTable.Horses.Select(h => new HorseModel(h)).ToList();
    }
  }
}