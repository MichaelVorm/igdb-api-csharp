using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IReleaseDateService
    {
        ReleaseDate GetReleaseDateById(int id);
        List<ReleaseDate> SearchReleaseDatesByName(string name);
    }
}
