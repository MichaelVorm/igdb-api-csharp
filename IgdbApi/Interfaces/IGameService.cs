using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IGameService
    {

        Game GetGameById(int id);
        List<Game> SearchGamesByName(string name);
    }
}
