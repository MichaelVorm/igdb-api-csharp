using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IGameEngineService
    {

        GameEngine GetGameEngineById(int id);
        List<GameEngine> SearchGameEnginesByName(string name);
    }
}
