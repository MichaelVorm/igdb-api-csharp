﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IgdbApi.Dto;
using IgdbApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IgdbApi.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        private IApiService _apiService { get; }

        public GameController(IApiService apiService)
        {
            _apiService = apiService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public Game GetGameById(int id)
        {
           var game = _apiService.GetGameById(id);

           return game;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Game> SearchGamesByName(string name)
        {
            var game = _apiService.SearchGamesByName(name);

            return game;
        }
    }
}
