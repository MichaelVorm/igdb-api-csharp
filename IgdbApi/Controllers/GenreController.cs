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
    public class GenreController : Controller
    {
        private IGenreService _genreService { get; }

        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public Genre GetGenreById(int id)
        {
           var genre = _genreService.GetGenreById(id);

           return genre;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Genre> SearchGenresByName(string name)
        {
            var genres = _genreService.SearchGenresByName(name);

            return genres;
        }
    }
}
