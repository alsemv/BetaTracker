using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetaTracker.Models.GameModel
{
    public class DefaultSku
    {
        public string display_price { get; set; }
        public string id { get; set; }
        public int price { get; set; }
        public List<Reward> rewards { get; set; }
        public bool seasonPassExclusiveFlag { get; set; }
    }
}
