using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetaTracker.Models.GameModel
{
    public class Reward
    {
        public string id { get; set; }
        public string entitlement_id { get; set; }
        public string service_provider_id { get; set; }
        public int discount { get; set; }
        public int price { get; set; }
        public int reward_type { get; set; }
        public string display_price { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool isPlus { get; set; }
        public int reward_source_type_id { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
    }
}
