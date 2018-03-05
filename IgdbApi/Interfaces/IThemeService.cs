using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IThemeService
    {

        Theme GetThemeById(int id);
        List<Theme> SearchThemesByName(string name);
    }
}
