using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IgdbApi.Services;
using IgdbApi.Dto;
using IgdbApi.Interfaces;

namespace IgdbApi.Controllers
{
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {
        private ICharacterService _characterService { get; }

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
        // GET api/<controller>/5

        [HttpGet("{id}")]
        public Character GetCharacterById(int id)
        {
            var character = _characterService.GetCharacterById(id);

            return character;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Character> SearchCharactersByName(string name)
        {
            var characters = _characterService.SearchCharactersByName(name);

            return characters;
        }
    }
}