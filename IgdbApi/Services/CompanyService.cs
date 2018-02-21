using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class CompanyService : ICompanyService
    {
        private IApiClient _apiClient;

        public CompanyService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Company GetCompanyById(int id)
        {
            string requestUri = string.Format("/companies/{0}?fields=*", id);
            var companies = _apiClient.Get<List<Company>>(requestUri).Result;

            return companies[0];
        }

        public List<Company> SearchCompaniesByName(string name)
        {
            string requestUri = string.Format("/companies/?search={0}&fields=*", name);
            var companies = _apiClient.Get<List<Company>>(requestUri).Result;

            return companies;
        }
    }
}
