using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class GameVersionService : IGameVersionService
    {
        private IApiClient _apiClient;

        public GameVersionService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public GameVersion GetGameVersionById(int id)
        {
            string requestUri = string.Format("/game_versions/{0}?fields=*", id);
            var gameVersion =  _apiClient.Get<List<GameVersion>>(requestUri).Result;

            return gameVersion[0];        
        }

        public List<GameVersion> SearchGameVersionsByName(string name)
        {
            string requestUri = string.Format("/game_versions/?search={0}&fields=*", name);
            var gameVersions = _apiClient.Get<List<GameVersion>>(requestUri).Result;

            return gameVersions;
        }
    }
}
