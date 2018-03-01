using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class PulseGroupService : IPulseGroupService
    {
        private IApiClient _apiClient;

        public PulseGroupService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public PulseGroup GetPulseGroupById(int id)
        {
            string requestUri = string.Format("/pulse_groups/{0}?fields=*", id);
            var pulseGroup = _apiClient.Get<List<PulseGroup>>(requestUri).Result;

            return pulseGroup[0];
        }

        public List<PulseGroup> SearchPulseGroupsByName(string name)
        {
            string requestUri = string.Format("/pulse_groups/?search={0}&fields=*", name);
            var pulseGroups = _apiClient.Get<List<PulseGroup>>(requestUri).Result;

            return pulseGroups;
        }
    }
}
