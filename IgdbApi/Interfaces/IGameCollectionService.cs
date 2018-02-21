using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IGameCollectionService
    {
        GameCollection GetGameCollectionById(int id);
        List<GameCollection> SearchGameCollectionsByName(string name);
    }
}
