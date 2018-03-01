using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IPlayerPerspectiveService
    {

        PlayerPerspective GetPlayerPerspectiveById(int id);
        List<PlayerPerspective> SearchPlayerPerspectivesByName(string name);
    }
}
