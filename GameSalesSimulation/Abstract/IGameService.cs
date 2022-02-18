﻿using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        List<Game> GetAllGames(Game game);
    }
}
