﻿using System;
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
    public class CompanyController : Controller
    {
        private ICompanyService _companyService { get; }

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        // GET api/<controller>/5

        [HttpGet("{id}")]
        public Company GetCompanyById(int id)
        {
            var company = _companyService.GetCompanyById(id);

            return company;
        }

        // GET api/<controller>/5
        [Route("search/{name}")]
        [HttpGet]
        public List<Company> SearchCompaniesByName(string name)
        {
            var companies = _companyService.SearchCompaniesByName(name);

            return companies;
        }
    }
}