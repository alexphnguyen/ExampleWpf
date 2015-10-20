
using System.Collections.Generic;
using DataModel;
using Enity;
using System.Linq;

namespace API {
  public class HorseAPI {
    public List<HorseModel> GetAllHorses() {
      return Enity.HorsesTable.Horses.Select(h => new HorseModel(h)).ToList();
    }
  }
}