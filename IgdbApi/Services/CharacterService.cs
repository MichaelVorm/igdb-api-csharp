using IgdbApi.Dto;
using IgdbApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Services
{
    public class CharacterService : ICharacterService
    {
        private IApiClient _apiClient;

        public CharacterService(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Character GetCharacterById(int id)
        {
            string requestUri = string.Format("/characters/{0}?fields=*", id);
            var characters = _apiClient.Get<List<Character>>(requestUri).Result;

            return characters[0];
        }

        public List<Character> SearchCharactersByName(string name)
        {
            string requestUri = string.Format("/characters/?search={0}&fields=*", name);
            var characters = _apiClient.Get<List<Character>>(requestUri).Result;

            return characters;
        }
    }
}
