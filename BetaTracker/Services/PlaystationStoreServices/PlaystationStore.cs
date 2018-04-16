using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BetaTracker.Models.GameModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BetaTracker.Services.PlaystationStoreServices
{
    public class PlaystationStore : IPlaystationStoreApi
    {
        protected string StoreUrl;

        public async Task<Root> LoadData(string gameId)
        {
            string url = StoreUrl + gameId;

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(url))
            using (HttpContent content = response.Content)
            {
                string data = await content.ReadAsStringAsync();
                JObject obj = JObject.Parse(data);

                Root root = JsonConvert.DeserializeObject<Root>(obj.ToString());
                return root;
            }
        }
    }
}