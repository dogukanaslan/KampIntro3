using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Abstract
{
    interface IOrderService 
    {
        void Add(Order order, Game game, Gamer gamer, Campaign campaign);
        void Update(Order order, Game game, Gamer gamer, Campaign campaign);
        void Delete(Order order, Game game, Gamer gamer, Campaign campaign);
    }
}
