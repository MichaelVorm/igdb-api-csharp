using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IgdbApi.Services;
using IgdbApi.Dto;

namespace IgdbApi.Controllers
{
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {
        private IApiService _apiClient { get; }

        public CharacterController(IApiService apiClient)
        {
            _apiClient = apiClient;
        }
        // GET api/<controller>/5

        [HttpGet("{id}")]
        public Character GetCharacterById(int id)
        {
            var game = _apiClient.GetCharacterById(id);

            return game;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Character> SearchCharactersByName(string name)
        {
            var characters = _apiClient.SearchCharactersByName(name);

            return characters;
        }
    }
}