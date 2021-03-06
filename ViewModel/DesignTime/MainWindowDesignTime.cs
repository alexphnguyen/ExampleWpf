﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using BusinessModel;

namespace ViewModel.DesignTime {
  public class MainWindowDesignTime : MainWindowViewModel {
    public MainWindowDesignTime()
      : base(true) {
      /*
       * The purpose of these default values are to populate the design time view.
       * They will not appear at runtime.
       * This allows you to easily style the View,
       * previewing things like font color,
       * botton border size,
       * or the apperance of a selected item in a list.
       */
      SelectedHorse = new HorseViewModel(new HorseModel {
        Name = "Selected Horse",
        Legs = 0,
      });
      Horses = new ObservableCollection<HorseViewModel> {
        new HorseViewModel(new HorseModel { Name = "Horse 1" }),
        new HorseViewModel(new HorseModel { Name = "Horse 2" }),
      };
    }
  }
}