using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class TitleService : ITitleService
    {
        private IApiClient _apiClient;

        public TitleService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Title GetTitleById(int id)
        {
            string requestUri = string.Format("/titles/{0}?fields=*", id);
            var title = _apiClient.Get<List<Title>>(requestUri).Result;

            return title[0];
        }

        public List<Title> SearchTitlesByName(string name)
        {
            string requestUri = string.Format("/titles/?search={0}&fields=*", name);
            var titles = _apiClient.Get<List<Title>>(requestUri).Result;

            return titles;
        }
    }
}
