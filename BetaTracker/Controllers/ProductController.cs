using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetaTracker.Models.GameModel;
using BetaTracker.Services.PlaystationStoreServices;
using BetaTracker.Utilities.Languages;
using Microsoft.AspNetCore.Mvc;

namespace BetaTracker.Controllers
{
    public class ProductController : Controller
    {
        public string index(string lang)
        {
            Country country = LanguagesHelper.GetCountry(lang);
            return $"country: {country.shortName}, language: {country.language}";
        }

        [HttpGet]
        [Route("/{lang}/product/{id}")]
        public string item(string lang, string id, SingleGameService single)
        {
            Task<Root> root = single.LoadData(id);
            Root gameInfo = root.Result;
            return $"id name: {id}, lang: {lang}";
        }
    }
}
