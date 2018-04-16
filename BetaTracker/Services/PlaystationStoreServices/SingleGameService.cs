using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetaTracker.Services.PlaystationStoreServices
{
    public class SingleGameService : PlaystationStore
    {
        public SingleGameService()
        {
            StoreUrl = "http://server.temp/container/";
        }
    }
}
