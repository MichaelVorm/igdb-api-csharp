using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface ICompanyService
    {
        Company GetCompanyById(int id);

        List<Company> SearchCompaniesByName(string name);
    }
}
