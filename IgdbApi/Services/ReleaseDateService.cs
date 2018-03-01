using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class ReleaseDateService : IReleaseDateService
    {
        private IApiClient _apiClient;

        public ReleaseDateService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public ReleaseDate GetReleaseDateById(int id)
        {
            string requestUri = string.Format("/release_dates/{0}?fields=*", id);
            var releaseDate = _apiClient.Get<List<ReleaseDate>>(requestUri).Result;

            return releaseDate[0];
        }

        public List<ReleaseDate> SearchReleaseDatesByName(string name)
        {
            string requestUri = string.Format("/release_dates/?search={0}&fields=*", name);
            var realeaseDates = _apiClient.Get<List<ReleaseDate>>(requestUri).Result;

            return realeaseDates;
        }
    }
}
