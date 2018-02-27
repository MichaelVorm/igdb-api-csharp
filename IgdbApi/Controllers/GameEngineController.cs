using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IgdbApi.Dto;
using IgdbApi.Interfaces;
using IgdbApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IgdbApi.Controllers
{
    [Route("api/[controller]")]
    public class GameEngineController : Controller
    {
        private IGameEngineService _gameEngineService { get; }

        public GameEngineController(IGameEngineService gameEngineService)
        {
            _gameEngineService = gameEngineService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public GameEngine GetGameEngineById(int id)
        {
           var gameEngine = _gameEngineService.GetGameEngineById(id);

           return gameEngine;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<GameEngine> SearchGameEnginesByName(string name)
        {
            var gameEngines = _gameEngineService.SearchGameEnginesByName(name);

            return gameEngines;
        }
    }
}
