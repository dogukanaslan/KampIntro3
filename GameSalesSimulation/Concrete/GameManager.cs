using System;
using GameSalesSimulation.Abstract;
using System.Collections.Generic;
using System.Text;
using GameSalesSimulation.Entities;

namespace GameSalesSimulation.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Eklendi. : " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi. : " + game.GameName);
        }

        public List<Game> GetAllGames(Game game)
        {
            List<Game> games = new List<Game>() {game };

            foreach (var item in games)
            {
                Console.WriteLine("Oyun Listelendi" + "  :  " + game.GameName);
            }
            return games;
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi. : " + game.GameName);
        }
    }
}
