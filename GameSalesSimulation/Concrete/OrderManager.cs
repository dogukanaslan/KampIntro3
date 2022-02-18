using System;
using GameSalesSimulation.Abstract;
using System.Collections.Generic;
using System.Text;
using GameSalesSimulation.Entities;

namespace GameSalesSimulation.Concrete
{
    class OrderManager : IOrderService 
    {
        public void Add(Order order,Game game, Gamer gamer,Campaign campaign)
        {
            Console.WriteLine("Sipariş Alındı. : " + order.OrderId + " : " + game.GameName + " : " +  gamer.FirstName + gamer.LastName + "  " + "Kampanya Türü : " + campaign.CampaignName);
        }

        public void Delete(Order order, Game game, Gamer gamer,Campaign campaign)
        {
            Console.WriteLine("Sipariş Silindi. : " + order.OrderId + " : " + game.GameName + " : " + gamer.FirstName + gamer.LastName);
        }

        public void Update(Order order, Game game, Gamer gamer,Campaign campaign)
        {
            Console.WriteLine("Sipariş Güncellendi : " + order.OrderId + " : " + game.GameName + " : " + gamer.FirstName + gamer.LastName);
        }
    }
}
