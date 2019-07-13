using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette.ViewModels 
{
     public class BetItemsViewModel : Bace.ViewModel
    {
        public double BET { set; get; }
        public double X { set; get; }
        public string Numbers { set; get; }
        public BetItemsViewModel()
        {

        }
    }
}
