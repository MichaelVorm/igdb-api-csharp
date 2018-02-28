using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class PersonService : IPersonService
    {
        private IApiClient _apiClient;

        public PersonService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Person GetPersonById(int id)
        {
            string requestUri = string.Format("/people/{0}?fields=*", id);
            var person = _apiClient.Get<List<Person>>(requestUri).Result;

            return person[0];
        }

        public List<Person> SearchPersonsByName(string name)
        {
            string requestUri = string.Format("/people/?search={0}&fields=*", name);
            var persons = _apiClient.Get<List<Person>>(requestUri).Result;

            return persons;
        }
    }
}
