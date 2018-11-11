using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ALL_LABS.Helpers
{
    public static class AlgoWiki
    {
        private static readonly HttpClient client = new HttpClient();

        public static Dictionary<string, string> UriDictionary = new Dictionary<string, string>()
        {
            {
                "MAGMA", "https://ru.m.wikipedia.org/wiki/%D0%93%D0%9E%D0%A1%D0%A2_28147-89"
            },
            {
                "CESAR", "https://ru.m.wikipedia.org/wiki/%D0%A8%D0%B8%D1%84%D1%80_%D0%A6%D0%B5%D0%B7%D0%B0%D1%80%D1%8F"
            },
            {
                "VIJENER", "https://ru.m.wikipedia.org/wiki/%D0%A8%D0%B8%D1%84%D1%80_%D0%92%D0%B8%D0%B6%D0%B5%D0%BD%D0%B5%D1%80%D0%B0"
            },
            {
                "VIJENER_PSEUDO", "https://ru.m.wikipedia.org/wiki/%D0%A8%D0%B8%D1%84%D1%80_%D0%92%D0%B8%D0%B6%D0%B5%D0%BD%D0%B5%D1%80%D0%B0"
            }
        };

        public static string GetInfo(string algoName)
        {
            var uri = UriDictionary[algoName];
            var response = client.GetAsync(uri).Result.Content.ToString();
            return response;
        }
    }
}
