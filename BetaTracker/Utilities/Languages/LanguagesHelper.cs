using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace BetaTracker.Utilities.Languages
{
    public static class LanguagesHelper
    {
        private static Dictionary<string, Country> counties = new Dictionary<string, Country>
        {
            { "us-en", new Country {shortName = "us", language = "en"} },
            { "ar-es", new Country {shortName = "ar", language = "es"} }
        };

        public static bool checkCountry(string country)
        {
            return counties.ContainsKey(country);
        }

        public static Country GetCountry(string lang)
        {
            return counties[lang];
        }
    }
}
