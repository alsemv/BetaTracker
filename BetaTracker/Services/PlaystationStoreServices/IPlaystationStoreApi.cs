using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetaTracker.Models.GameModel;

namespace BetaTracker.Services.PlaystationStoreServices
{
    public interface IPlaystationStoreApi
    {
        Task<Root> LoadData(string gameId);
    }
}
