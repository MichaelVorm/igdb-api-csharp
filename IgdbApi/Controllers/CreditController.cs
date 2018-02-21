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
    public class CreditController : Controller
    {
        private ICreditService _creditService { get; }

        public CreditController(ICreditService creditService)
        {
            _creditService = creditService;
        }
        // GET api/<controller>/5

        [HttpGet("{id}")]
        public Credit GetCreditById(int id)
        {
            var credit = _creditService.GetCreditById(id);

            return credit;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Credit> SearchCreditsByName(string name)
        {
            var credits = _creditService.SearchCreditsByName(name);

            return credits;
        }
    }
}