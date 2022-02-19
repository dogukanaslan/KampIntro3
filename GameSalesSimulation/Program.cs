using GameSalesSimulation.Abstract;
using GameSalesSimulation.Concrete;
using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;

namespace GameSalesSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.FirstName = "Doğukan";
            gamer.LastName = "Aslan";
            gamer.BirthYear = 2003;
            gamer.NationalityId = "22718251468";

            Order order = new Order();
            order.OrderId = 13233;

            Game game1 = new Game();
            game1.GameName = "The Witcher";
            Game game2 = new Game();
            game2.GameName = "Valorant";

            Campaign campaign = new Campaign();
            campaign.CampaignName = "Yeni Yıl İndirimi";

            GameManager gameManager = new GameManager();
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            OrderManager orderManager = new OrderManager();
            gamerManager.Add(gamer);
            orderManager.Add(order, game1, gamer, campaign);
            gameManager.GetAllGames(game1);
            gameManager.GetAllGames(game2);
            
        }
    }
}
