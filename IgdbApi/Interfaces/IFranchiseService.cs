using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IFranchiseService
    {
        Franchise GetFranchiseById(int id);
        List<Franchise> SearchFranchisesByName(string name);
    }
}
