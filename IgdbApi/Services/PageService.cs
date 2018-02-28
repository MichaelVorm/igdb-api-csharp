using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class PageService : IPageService
    {
        private IApiClient _apiClient;

        public PageService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Page GetPageById(int id)
        {
            string requestUri = string.Format("/pages/{0}?fields=*", id);
            var page = _apiClient.Get<List<Page>>(requestUri).Result;

            return page[0];
        }

        public List<Page> SearchPagesByName(string name)
        {
            string requestUri = string.Format("/pages/?search={0}&fields=*", name);
            var pages = _apiClient.Get<List<Page>>(requestUri).Result;

            return pages;
        }
    }
}
