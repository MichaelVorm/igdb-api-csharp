using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class PulseService : IPulseService
    {
        private IApiClient _apiClient;

        public PulseService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Pulse GetPulseById(int id)
        {
            string requestUri = string.Format("/pulses/{0}?fields=*", id);
            var pulse = _apiClient.Get<List<Pulse>>(requestUri).Result;

            return pulse[0];
        }

        public List<Pulse> SearchPulsesByName(string name)
        {
            string requestUri = string.Format("/pulses/?search={0}&fields=*", name);
            var pulses = _apiClient.Get<List<Pulse>>(requestUri).Result;

            return pulses;
        }
    }
}
