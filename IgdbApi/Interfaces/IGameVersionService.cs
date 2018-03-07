using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IGameVersionService
    {

        GameVersion GetGameVersionById(int id);
        List<GameVersion> SearchGameVersionsByName(string name);
    }
}
