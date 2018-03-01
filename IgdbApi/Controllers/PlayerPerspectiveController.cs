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
    public class PlayerPerspectiveController : Controller
    {
        private IPlayerPerspectiveService _playerPerspectiveService { get; }

        public PlayerPerspectiveController(IPlayerPerspectiveService playerPerspectiveService)
        {
            _playerPerspectiveService = playerPerspectiveService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public PlayerPerspective GetPlayerPerspectiveById(int id)
        {
           var game = _playerPerspectiveService.GetPlayerPerspectiveById(id);

           return game;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<PlayerPerspective> SearchPlayerPerspectivesByName(string name)
        {
            var game = _playerPerspectiveService.SearchPlayerPerspectivesByName(name);

            return game;
        }
    }
}
