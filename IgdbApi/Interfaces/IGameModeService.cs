﻿using IgdbApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgdbApi.Interfaces
{
    public interface IGameModeService
    {
        GameMode GetGameModeById(int id);
        List<GameMode> SearchGameModesByName(string name);
    }
}