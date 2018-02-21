using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class GameService : IGameService
    {
        private IApiClient _apiClient;

        public GameService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Game GetGameById(int id)
        {
            string requestUri = string.Format("/games/{0}?fields=*", id);
            var game = _apiClient.Get<List<Game>>(requestUri).Result;

            return game[0];
        }

        public List<Game> SearchGamesByName(string name)
        {
            string requestUri = string.Format("/games/?search={0}&fields=*", name);
            var games = _apiClient.Get<List<Game>>(requestUri).Result;

            return games;
        }
    }
}
