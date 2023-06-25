using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaGierProjekt.MVVM.Model
{
    internal class GameModel
    {
        public string GameName { get; set; }
        public string AvailableForPurchase { get; set; }
        public string AvailableForRental { get; set; }
        public string PriceForPurchase { get; set; }
        public string PriceForRental { get; set; }
    }
}
