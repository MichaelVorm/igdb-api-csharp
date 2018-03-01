using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class PulseSourceService : IPulseSourceService
    {
        private IApiClient _apiClient;

        public PulseSourceService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public PulseSource GetPulseSourceById(int id)
        {
            string requestUri = string.Format("/pulse_sources/{0}?fields=*", id);
            var pulseSource = _apiClient.Get<List<PulseSource>>(requestUri).Result;

            return pulseSource[0];
        }

        public List<PulseSource> SearchPulseSourcesByName(string name)
        {
            string requestUri = string.Format("/pulse_sources/?search={0}&fields=*", name);
            var pulseSources = _apiClient.Get<List<PulseSource>>(requestUri).Result;

            return pulseSources;
        }
    }
}
