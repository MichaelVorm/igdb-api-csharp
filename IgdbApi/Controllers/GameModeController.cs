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
    public class GameModeController : Controller
    {
        private IGameModeService _gameModeService { get; }

        public GameModeController(IGameModeService gameModeService)
        {
            _gameModeService = gameModeService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public GameMode GetGameModeById(int id)
        {
           var gameMode = _gameModeService.GetGameModeById(id);

           return gameMode;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<GameMode> SearchGameModesByName(string name)
        {
            var gameModes = _gameModeService.SearchGameModesByName(name);

            return gameModes;
        }
    }
}
