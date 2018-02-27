using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class GameEngineService : IGameEngineService
    {
        private IApiClient _apiClient;

        public GameEngineService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public GameEngine GetGameEngineById(int id)
        {
            string requestUri = string.Format("/game_engines/{0}?fields=*", id);
            var gameEngine = _apiClient.Get<List<GameEngine>>(requestUri).Result;

            return gameEngine[0];
        }

        public List<GameEngine> SearchGameEnginesByName(string name)
        {
            string requestUri = string.Format("/game_engines/?search={0}&fields=*", name);
            var gameEngines = _apiClient.Get<List<GameEngine>>(requestUri).Result;

            return gameEngines;
        }
    }
}
