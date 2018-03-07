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
    public class GameVersionController : Controller
    {
        private IGameVersionService _versionService { get; }

        public GameVersionController(IGameVersionService versionService)
        {
            _versionService = versionService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public GameVersion GetVersionById(int id)
        {
           var gameVersion = _versionService.GetGameVersionById(id);

           return gameVersion;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<GameVersion> SearchVersionsByName(string name)
        {
            var gameVersions = _versionService.SearchGameVersionsByName(name);

            return gameVersions;
        }
    }
}
