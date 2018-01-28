using IgdbApi.Dto;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class ApiService : IApiService
    {    
        private IApiClient _apiClient;

        public ApiService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Character GetCharacterById(int id)
        {
            string requestUri = string.Format("/characters/{0}?fields=*", id);
            var characters = _apiClient.Get<List<Character>>(requestUri).Result;

            return characters[0];
        }

        public Game GetGameById(int id)
        {
            string requestUri = string.Format("/games/{0}?fields=*", id);
            var game = _apiClient.Get<List<Game>>(requestUri).Result;
            
            return game[0];
        }

        public GameCollection GetGameCollectionById(int id)
        {
            string requestUri = string.Format("/collections/{0}?fields=*", id);
            var gameCollection = _apiClient.Get<List<GameCollection>>(requestUri).Result;

            return gameCollection[0];
        }

        public List<GameCollection> SeachGameCollectionsByName(string name)
        {
            string requestUri = string.Format("/collections/?search={0}&fields=*", name);
            var gameCollections = _apiClient.Get<List<GameCollection>>(requestUri).Result;

            return gameCollections;
        }

        public List<Character> SearchCharactersByName(string name)
        {
            string requestUri = string.Format("/characters/?search={0}&fields=*", name);
            var characters = _apiClient.Get<List<Character>>(requestUri).Result;

            return characters;
        }

        public List<Game> SearchGamesByName(string name)
        {
            string requestUri = string.Format("/games/?search={0}&fields=*", name);
            var games = _apiClient.Get<List<Game>>(requestUri).Result;

            return games;
        }
    }
}
