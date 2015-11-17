
using System.Collections.Generic;
using Entity;
using System.Linq;
using BusinessModel;

namespace Api {
  public static class HorseApi {
    public static List<HorseModel> GetAllHorses() {
      return HorsesTable.Horses.Select(h => new HorseModel(h)).ToList();
    }
  }
}