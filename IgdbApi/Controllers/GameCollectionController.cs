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
    public class GameCollectionController : Controller
    {
        private IGameCollectionService _gameCollectionService { get; }

        public GameCollectionController(IGameCollectionService gameCollectionService)
        {
            _gameCollectionService = gameCollectionService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public GameCollection GetGameCollectionById(int id)
        {
           var game = _gameCollectionService.GetGameCollectionById(id);

           return game;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<GameCollection> SearchGameCollectionsByName(string name)
        {
            var game = _gameCollectionService.SearchGameCollectionsByName(name);

            return game;
        }
    }
}
