using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IgdbApi.Services;
using IgdbApi.Dto;
using IgdbApi.Interfaces;

namespace IgdbApi.Controllers
{
    [Route("api/[controller]")]
    public class FranchiseController : Controller
    {
        private IFranchiseService _franchiseService { get; }

        public FranchiseController(IFranchiseService franchiseService)
        {
            _franchiseService = franchiseService;
        }
        // GET api/<controller>/5

        [HttpGet("{id}")]
        public Franchise GetFranchiseById(int id)
        {
            var franchise = _franchiseService.GetFranchiseById(id);

            return franchise;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Franchise> SearchFranchisesByName(string name)
        {
            var franchises = _franchiseService.SearchFranchisesByName(name);

            return franchises;
        }
    }
}