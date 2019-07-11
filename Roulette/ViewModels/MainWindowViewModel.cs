using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette.ViewModels
{
    class MainWindowViewModel :Bace.ViewModel
    {
        public ObservableCollection <BetItemsViewModel> BetListItems { get; set; }

        public Command bet_0 { set; get; }
        public Command bet_1 { set; get; }
        public Command bet_2 { set; get; }
        public Command bet_3 { set; get; }
        public Command bet_4 { set; get; }
        public Command bet_5 { set; get; }
        public Command bet_6 { set; get; }
        public Command bet_7 { set; get; }
        public Command bet_8 { set; get; }
        public Command bet_9 { set; get; }
        public Command bet_10 { set; get; }
        public Command bet_11 { set; get; }
        public Command bet_12 { set; get; }
        public Command bet_13 { set; get; }
        public Command bet_14 { set; get; }
        public Command bet_15 { set; get; }
        public Command bet_16 { set; get; }
        public Command bet_17 { set; get; }
        public Command bet_18 { set; get; }
        public Command bet_19 { set; get; }
        public Command bet_20 { set; get; }
        public Command bet_21 { set; get; }
        public Command bet_22 { set; get; }
        public Command bet_23 { set; get; }
        public Command bet_24 { set; get; }
        public Command bet_25 { set; get; }
        public Command bet_26 { set; get; }
        public Command bet_27 { set; get; }
        public Command bet_28 { set; get; }
        public Command bet_30 { set; get; }
        public Command bet_31 { set; get; }
        public Command bet_32 { set; get; }
        public Command bet_33 { set; get; }
        public Command bet_34 { set; get; }
        public Command bet_35 { set; get; }
        public Command bet_36 { set; get; }


        public MainWindowViewModel()
        {
            BetListItems = new ObservableCollection<BetItemsViewModel>();
            BetListItems.Add(new BetItemsViewModel { BET = "500", X = "1.5", Numbers = "1,2,3,4,5,6,7" });
            BetListItems.Add(new BetItemsViewModel { BET = "100", X = "1.5", Numbers = "1,2,3,4,5,6,7" });
            BetListItems.Add(new BetItemsViewModel { BET = "200", X = "1.5", Numbers = "1,2,3,4,5,6,7" });
            BetListItems.Add(new BetItemsViewModel { BET = "50", X = "1.5", Numbers = "1,2,3,4,5,6,7" });
            BetListItems.Add(new BetItemsViewModel { BET = "5", X = "1.5", Numbers = "1,2,3,4,5,6,7" });
        }

        void Comands()
        {
            bet_0 = new Command(
                () =>{
              });
        }

    }
}
