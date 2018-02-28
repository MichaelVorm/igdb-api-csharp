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
    public class PersonController : Controller
    {
        private IPersonService _personService { get; }

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public Person GetPersonById(int id)
        {
           var person = _personService.GetPersonById(id);

           return person;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Person> SearchPersonsByName(string name)
        {
            var person = _personService.SearchPersonsByName(name);

            return person;
        }
    }
}
