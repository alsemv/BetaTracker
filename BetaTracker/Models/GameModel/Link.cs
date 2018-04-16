using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetaTracker.Models.GameModel
{
    public class Link
    {
        public string name { get; set; }
        public List<LinkImage> images { get; set; }
        public string url { get; set; }
    }
}
