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
    public class PulseController : Controller
    {
        private IPulseService _pulseService { get; }

        public PulseController(IPulseService pulseService)
        {
            _pulseService = pulseService;
        }
        // GET api/<controller>/5
        
        [HttpGet("{id}")]
        public Pulse GetPulseById(int id)
        {
           var pulse = _pulseService.GetPulseById(id);

           return pulse;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Pulse> SearchPulsesByName(string name)
        {
            var pulses = _pulseService.SearchPulsesByName(name);

            return pulses;
        }
    }
}
