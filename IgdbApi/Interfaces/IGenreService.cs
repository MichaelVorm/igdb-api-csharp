using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IGenreService
    {

        Genre GetGenreById(int id);
        List<Genre> SearchGenresByName(string name);
    }
}
