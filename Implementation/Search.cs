using Newtonsoft.Json;
using SwaggerAPI.Models;
using SwaggerAPI.Repository;
using SwaggerAPI.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SwaggerAPI.Implementation
{
    public class Search : ISearch
    {
        public async Task<SearchResult> SearchData(SearchData searchData)
        {
            var call_chuck = await SD.GetStringAsync(SD.baseUrlChuck + "search?query=" + searchData.q_category);
            var call_swapi = await SD.GetStringAsync(SD.baseUrlSwapi + "people/?search=" + searchData.q_people);
            var people = JsonConvert.DeserializeObject<People>(call_swapi);
            var categories = JsonConvert.DeserializeObject<Categories>(call_chuck);

            var searchResult = new SearchResult()
            {
                People = (People)people,
                Categories = (Categories)categories
            };
            return searchResult;
        }
       
    }
}
