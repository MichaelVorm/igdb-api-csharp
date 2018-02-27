using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class KeywordService : IKeywordService
    {
        private IApiClient _apiClient;

        public KeywordService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Keyword GetKeywordById(int id)
        {
            string requestUri = string.Format("/games/{0}?fields=*", id);
            var keyword = _apiClient.Get<List<Keyword>>(requestUri).Result;

            return keyword[0];
        }

        public List<Keyword> SearchKeywordsByName(string name)
        {
            string requestUri = string.Format("/games/?search={0}&fields=*", name);
            var keywords = _apiClient.Get<List<Keyword>>(requestUri).Result;

            return keywords;
        }
    }
}
