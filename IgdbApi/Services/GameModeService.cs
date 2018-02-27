using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class GameModeService : IGameModeService
    {
        private IApiClient _apiClient;

        public GameModeService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public GameMode GetGameModeById(int id)
        {
            string requestUri = string.Format("/game_modes/{0}?fields=*", id);
            var gameMode = _apiClient.Get<List<GameMode>>(requestUri).Result;

            return gameMode[0];
        }

        public List<GameMode> SearchGameModesByName(string name)
        {
            string requestUri = string.Format("/game_modes/?search={0}&fields=*", name);
            var gameModes = _apiClient.Get<List<GameMode>>(requestUri).Result;

            return gameModes;
        }
    }
}
