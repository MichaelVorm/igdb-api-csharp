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
    public class PlatformController : Controller
    {
        private IPlatformService _platformService { get; }

        public PlatformController(IPlatformService platformService)
        {
            _platformService = platformService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public Platform GetGameById(int id)
        {
           var game = _platformService.GetPlatformById(id);

           return game;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Platform> SearchPlatformsByName(string name)
        {
            var platforms = _platformService.SearchPlatformsByName(name);

            return platforms;
        }
    }
}
