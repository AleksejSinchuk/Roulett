using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Roulette.ViewModels
{
    class MainWindowViewModel :Bace.ViewModel
    {
        
        public ObservableCollection <BetItemsViewModel> BetListItems { get; set; }

        public string TextKolBet { get; set; } = "0";
        public double _TextKolBet;
        public double Score { get; set; } = 10000;
        public string Rnd { set; get; }


        public Command btnStart { set; get;}

        #region Command bet_*
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
        public Command bet_29 { set; get; }
        public Command bet_30 { set; get; }
        public Command bet_31 { set; get; }
        public Command bet_32 { set; get; }
        public Command bet_33 { set; get; }
        public Command bet_34 { set; get; }
        public Command bet_35 { set; get; }
        public Command bet_36 { set; get; }


        public Command bet_1_18 { set; get; }
        public Command bet_19_36 { set; get; }       
        public Command bet_1_12 { set; get; }
        public Command bet_13_24 { set; get; }
        public Command bet_25_36 { set; get; }
        public Command bet_even { set; get; }
        public Command bet_odd { set; get; }
        public Command bet_red { set; get; }
        public Command bet_black { set; get; } 
        public Command bet_2k1_1_34 { get; set; }
        public Command bet_2k1_2_35 { get; set; }
        public Command bet_2k1_3_36 { get; set; }


        public Command bet_1245 { set; get; }
        public Command bet_2356 { set; get; }
        public Command bet_5689 { set; get; }
        public Command bet_4578 { set; get; }
        public Command bet_891112 { set; get; }
        public Command bet_781011 { set; get; }
        public Command bet_11121415 { set; get; }
        public Command bet_10111314 { set; get; }
        public Command bet_14151718 { set; get; }
        public Command bet_13141617 { set; get; }
        public Command bet_17182021 { set; get; }
        public Command bet_16171920 { set; get; }
        public Command bet_20212324 { set; get; }
        public Command bet_19202223 { set; get; }
        public Command bet_23242627 { set; get; }
        public Command bet_22232526 { set; get; }
        public Command bet_26272930 { set; get; }
        public Command bet_25262829 { set; get; }
        public Command bet_28293132 { set; get; }
        public Command bet_29303233 { set; get; }
        public Command bet_32333536 { set; get; }
        public Command bet_31323435 { set; get; }
        
        

        #endregion

        public MainWindowViewModel()
        {
            BetListItems = new ObservableCollection<BetItemsViewModel>();

            Bets();
            btnStart = new Command(() => {
                Bets_Play(BetListItems);
            });

           

        }


         public void InBet(string _Numbers, double _X)
         {
            _TextKolBet = Convert.ToDouble(TextKolBet);
            Score -= _TextKolBet;
            BetListItems.Add(new BetItemsViewModel { BET = _TextKolBet, X =_X, Numbers = _Numbers });
            TextKolBet = "0";
            OnPropertyChanged(nameof(TextKolBet));
            OnPropertyChanged(nameof(Score));
         }
       

        public void Bets()
        {
            #region bet_0-36
            bet_0 = new Command(() =>
            {
                InBet("0", 36);
            });

            bet_1 = new Command(() =>
            {
                InBet("1", 36);
            });
            bet_2 = new Command(() =>
            {
                InBet("2", 36);
            });
            bet_3 = new Command(() =>
            {
                InBet("3", 36);
            });
            bet_4 = new Command(() =>
            {
                InBet("4", 36);
            });
            bet_5 = new Command(() =>
            {
                InBet("5", 36);
            });
            bet_6 = new Command(() =>
            {
                InBet("6", 36);
            });
            bet_7 = new Command(() =>
            {
                InBet("7", 36);
            });
            bet_8 = new Command(() =>
            {
                InBet("8", 36);
            });
            bet_9 = new Command(() =>
            {
                InBet("9", 36);
            });
            bet_10 = new Command(() =>
            {
                InBet("10", 36);
            });
            bet_11 = new Command(() =>
            {
                InBet("11", 36);
            });
            bet_12 = new Command(() =>
            {
                InBet("12", 36);
            });
            bet_13 = new Command(() =>
            {
                InBet("13", 36);
            });
            bet_14 = new Command(() =>
            {
                InBet("14", 36);
            });
            bet_15 = new Command(() =>
            {
                InBet("15", 36);
            });
            bet_16 = new Command(() =>
            {
                InBet("16", 36);
            });
            bet_17 = new Command(() =>
            {
                InBet("17", 36);
            });
            bet_18 = new Command(() =>
            {
                InBet("18", 36);
            });
            bet_19 = new Command(() =>
            {
                InBet("19", 36);
            });
            bet_20 = new Command(() =>
            {
                InBet("20", 36);
            });
            bet_21 = new Command(() =>
            {
                InBet("21", 36);
            });
            bet_22 = new Command(() =>
            {
                InBet("22", 1.5);
            });
            bet_23 = new Command(() =>
            {
                InBet("23", 36);
            });
            bet_24 = new Command(() =>
            {
                InBet("24", 36);
            });
            bet_25 = new Command(() =>
            {
                InBet("25", 36);
            });
            bet_26 = new Command(() =>
            {
                InBet("26", 36);
            });
            bet_27 = new Command(() =>
            {
                InBet("27", 36);
            });
            bet_28 = new Command(() =>
            {
                InBet("28", 36);
            });
            bet_29 = new Command(() =>
            {
                InBet("29", 36);
            });
            bet_30 = new Command(() =>
            {
                InBet("30", 36);
            });
            bet_31 = new Command(() =>
            {
                InBet("31", 36);

            });
            
            bet_32 = new Command(() =>
            {
                InBet("32", 36);
            });
            bet_33 = new Command(() =>
            {
                InBet("33", 36);
            });
            bet_34 = new Command(() =>
            {
                InBet("34", 36);
            });
            bet_35 = new Command(() =>
            {
                InBet("35", 36);
            });
            bet_36 = new Command(() =>
            {
                InBet("36", 36);
            });

            #endregion
                                  
            #region bets around
            bet_1_18 = new Command(() =>
            {
                InBet("1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18", 2);
            });
            bet_19_36 = new Command(() =>
            {
                InBet("19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36", 2);
            });
            bet_1_12 = new Command(() =>
            {
                InBet("1,2,3,4,5,6,7,8,9,10,11,12", 3);
            });
            bet_13_24 = new Command(() =>
            {
                InBet("13,14,15,16,17,18,19,20,21,22,23,24", 3);
            });
            bet_25_36 = new Command(() =>
            {
                InBet("25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36" , 3
);
            });
            bet_even = new Command(() =>
            {
                InBet("2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36", 2);
            });
            bet_odd = new Command(() =>
            {
                InBet("1,3,5,7,9,11,13,15,17,19,221,23,25,27,29,31,33,35", 2);
            });
            bet_red = new Command(() =>
            {
                InBet("1,3,5,7,9,12,14,16,18,19,21,23,25,27,30,32,34,36", 2);
            });
            bet_black = new Command(() =>
            {
                InBet("2,4,6,8,10,11,13,15,17,20,22,24,26,28,29,31,33,35", 2);
            });



            bet_2k1_1_34 = new Command(() =>
            {
                InBet("1,4,7,10,13,16,19,22,25,28,31,34", 3);
            });
            bet_2k1_2_35 = new Command(() =>
            {
                InBet("2,5,8,11,14,17,20,23,26,29,32,35", 3);
            });
            bet_2k1_3_36 = new Command(() =>
            {
                InBet("3,6,9,12,15,18,21,24,27,30,33,36", 3);
            });
            #endregion


            #region bets in fild

            bet_1245 = new Command(() =>
            {
                InBet("1,2,4,5", 9);
            });

            bet_2356 = new Command(() =>
            {
                InBet("2,3,5,6", 9);
            });
            bet_5689 = new Command(() =>
            {
                InBet("5,6,8,9", 9);
            });
            bet_4578 = new Command(() =>
            {
                InBet("4,5,7,8", 9);
            });
            bet_891112 = new Command(() =>
            {
                InBet("8,9,11,12", 9);
            });
            bet_781011 = new Command(() =>
            {
                InBet("7,8,10,11", 9);
            });
            bet_11121415 = new Command(() =>
            {
                InBet("11,12,14,15", 9);
            });
            bet_10111314 = new Command(() =>
            {
                InBet("10,11,13,14", 9);
            });
            bet_14151718 = new Command(() =>
            {
                InBet("14,15,17,18", 9);
            });
            bet_13141617 = new Command(() =>
            {
                InBet("13,14,16,17", 9);
            });
            bet_17182021 = new Command(() =>
            {
                InBet("17,18,20,21", 9);
            });
            bet_16171920 = new Command(() =>
            {
                InBet("16,17,19,20", 9);
            });
            bet_20212324 = new Command(() =>
            {
                InBet("20,21,23,24", 9);
            });
            bet_19202223 = new Command(() =>
            {
                InBet("19,20,22,23", 9);
            });
            bet_23242627 = new Command(() =>
            {
                InBet("23,24,26,27", 9);
            });
            bet_22232526 = new Command(() =>
            {
                InBet("22,23,25,26", 9);
            });
            bet_26272930 = new Command(() =>
            {
                InBet("26,27,29,30", 9);
            });
            bet_25262829 = new Command(() =>
            {
                InBet("25,26,28,29", 9);
            });
            bet_28293132 = new Command(() =>
            {
                InBet("28,29,31,32", 9);
            });
            bet_29303233 = new Command(() =>
            {
                InBet("29,30,32,33", 9);
            });
            bet_32333536 = new Command(() =>
            {
                InBet("32,33,35,36", 9);
            });
            bet_31323435 = new Command(() =>
            {
                InBet("31,32,34,35", 9);
            });
            #endregion
        }

        public void Bets_Play(ObservableCollection<BetItemsViewModel> List)
        {
            Random rnd = new Random();
          
            Rnd = Convert.ToString( rnd.Next(36)); 
           
            for(int i = 0; i < List.Count; i++)
            {
              int[] Nmbrs =  List[i].Numbers.Split(',').Select(s => Convert.ToInt32(s)).ToArray();
                for(int j = 0; j < Nmbrs.Length; j++)
                {
                    if (Nmbrs[j] == Convert.ToInt32(Rnd))
                    {
                        Score += (List[i].BET * List[i].X);
                    }
                }
            }
            OnPropertyChanged(nameof(Rnd));
            OnPropertyChanged(nameof(Score));
            BetListItems.Clear();
            OnPropertyChanged(nameof(TextKolBet)); 
        }

       
    }
}
