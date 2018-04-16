using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetaTracker.Models.GameModel
{
    public class Root
    {
        public int age_limit { get; set; }
        public string name { get; set; }
        public DefaultSku default_sku { get; set; }
        public List<Image> images { get; set; }
        public List<Link> links { get; set; }
        public string long_desc { get; set; }
        public MediaList mediaList { get; set; }
        public StarRating star_rating { get; set; }
    }
}
