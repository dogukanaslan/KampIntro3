using System;
using GameSalesSimulation.Abstract;
using System.Collections.Generic;
using System.Text;
using GameSalesSimulation.Entities;

namespace GameSalesSimulation.Concrete
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Müşteri Eklendi. : " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Müşteri Silindi. : " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Müşteri  Bilgisi Güncellendi. : " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
