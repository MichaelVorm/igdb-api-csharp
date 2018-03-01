using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class PlayTimeService : IPlayTimeService
    {
        private IApiClient _apiClient;

        public PlayTimeService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public PlayTime GetPlayTimeById(int id)
        {
            string requestUri = string.Format("/play_times/{0}?fields=*", id);
            var playTime = _apiClient.Get<List<PlayTime>>(requestUri).Result;

            return playTime[0];
        }

        public List<PlayTime> SearchPlayTimesByName(string name)
        {
            string requestUri = string.Format("/play_times/?search={0}&fields=*", name);
            var playTimes = _apiClient.Get<List<PlayTime>>(requestUri).Result;

            return playTimes;
        }
    }
}
