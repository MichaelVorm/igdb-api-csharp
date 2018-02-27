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
    public class KeywordController : Controller
    {
        private IKeywordService _keywordService { get; }

        public KeywordController(IKeywordService keywordService)
        {
            _keywordService = keywordService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public Keyword GetGenreById(int id)
        {
           var keyword = _keywordService.GetKeywordById(id);

           return keyword;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Keyword> SearchKeywordsByName(string name)
        {
            var keywords = _keywordService.SearchKeywordsByName(name);

            return keywords;
        }
    }
}
