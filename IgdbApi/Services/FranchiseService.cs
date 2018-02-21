using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class FranchiseService : IFranchiseService
    {
        private IApiClient _apiClient;

        public FranchiseService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Franchise GetFranchiseById(int id)
        {
            string requestUri = string.Format("/franchises/{0}?fields=*", id);
            var franchises = _apiClient.Get<List<Franchise>>(requestUri).Result;

            return franchises[0];
        }

        public List<Franchise> SearchFranchisesByName(string name)
        {
            string requestUri = string.Format("/franchises/?search={0}&fields=*", name);
            var franchises = _apiClient.Get<List<Franchise>>(requestUri).Result;

            return franchises;
        }
    }
}
