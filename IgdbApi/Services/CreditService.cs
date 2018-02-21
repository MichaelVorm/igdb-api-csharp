using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class CreditService : ICreditService
    {
        private IApiClient _apiClient;

        public CreditService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Credit GetCreditById(int id)
        {
            string requestUri = string.Format("/credits/{0}?fields=*", id);
            var credit = _apiClient.Get<List<Credit>>(requestUri).Result;

            return credit[0];
        }

        public List<Credit> SearchCreditsByName(string name)
        {
            string requestUri = string.Format("/credits/?search={0}&fields=*", name);
            var credits = _apiClient.Get<List<Credit>>(requestUri).Result;

            return credits;
        }
    }
}
