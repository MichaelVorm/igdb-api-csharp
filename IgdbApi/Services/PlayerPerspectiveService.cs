using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class PlayerPerspectiveService : IPlayerPerspectiveService
    {
        private IApiClient _apiClient;

        public PlayerPerspectiveService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public PlayerPerspective GetPlayerPerspectiveById(int id)
        {
            string requestUri = string.Format("/player_perspectives/{0}?fields=*", id);
            var playerPerspective = _apiClient.Get<List<PlayerPerspective>>(requestUri).Result;

            return playerPerspective[0];
        }

        public List<PlayerPerspective> SearchPlayerPerspectivesByName(string name)
        {
            string requestUri = string.Format("/player_perspectives/?search={0}&fields=*", name);
            var playerPerspectives = _apiClient.Get<List<PlayerPerspective>>(requestUri).Result;

            return playerPerspectives;
        }
    }
}
