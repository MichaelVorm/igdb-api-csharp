using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class GameCollectionService : IGameCollectionService
    {
        private IApiClient _apiClient;

        public GameCollectionService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public GameCollection GetGameCollectionById(int id)
        {
            string requestUri = string.Format("/collections/{0}?fields=*", id);
            var gameCollection = _apiClient.Get<List<GameCollection>>(requestUri).Result;

            return gameCollection[0];
        }

        public List<GameCollection> SearchGameCollectionsByName(string name)
        {
            string requestUri = string.Format("/collections/?search={0}&fields=*", name);
            var gameCollections = _apiClient.Get<List<GameCollection>>(requestUri).Result;

            return gameCollections;
        }
    }
}
