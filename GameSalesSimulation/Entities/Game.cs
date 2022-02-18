using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Entities
{
    class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
        public string Description { get; set; }
    }
}
