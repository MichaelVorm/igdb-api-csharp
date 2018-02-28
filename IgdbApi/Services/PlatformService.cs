using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class PlatformService : IPlatformService
    {
        private IApiClient _apiClient;

        public PlatformService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Platform GetPlatformById(int id)
        {
            string requestUri = string.Format("/platforms/{0}?fields=*", id);
            var platform = _apiClient.Get<List<Platform>>(requestUri).Result;

            return platform[0];
        }

        public List<Platform> SearchPlatformsByName(string name)
        {
            string requestUri = string.Format("/platforms/?search={0}&fields=*", name);
            var platforms = _apiClient.Get<List<Platform>>(requestUri).Result;

            return platforms;
        }
    }
}
