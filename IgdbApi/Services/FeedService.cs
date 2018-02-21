using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class FeedService : IFeedService
    {
        private IApiClient _apiClient;

        public FeedService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Feed GetFeedById(int id)
        {
            string requestUri = string.Format("/feeds/{0}?fields=*", id);
            var feeds = _apiClient.Get<List<Feed>>(requestUri).Result;

            return feeds[0];
        }

        public List<Feed> SearchFeedsByName(string name)
        {
            string requestUri = string.Format("/feeds/?search={0}&fields=*", name);
            var feeds = _apiClient.Get<List<Feed>>(requestUri).Result;

            return feeds;
        }
    }
}
