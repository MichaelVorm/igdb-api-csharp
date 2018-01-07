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

        public Game GetGameById(int id)
        {
            string requestUri = string.Format("/games/{0}?fields=*", id);
            var game = _apiClient.Get<Game>(requestUri).Result;

            return game;
        }

        public List<Game> SearchGamesByName(string name)
        {
            string requestUri = string.Format("/games/?search={0}&fields=*", name);
            var games = _apiClient.Get<List<Game>>(requestUri).Result;

            return games;
        }
    }
}
