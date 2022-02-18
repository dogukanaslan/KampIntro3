using GameSalesSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Entities
{
    public class Gamer : IGamerService
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("Gamer Added : " + gamer.FirstName + gamer.LastName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted : " + gamer.FirstName + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated" + gamer.FirstName + gamer.LastName);
        }
    }
}
