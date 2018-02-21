using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface ICharacterService
    {
        Character GetCharacterById(int id);
        List<Character> SearchCharactersByName(string name);
    }
}
