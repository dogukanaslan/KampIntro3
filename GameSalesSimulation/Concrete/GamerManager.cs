using System;
using GameSalesSimulation.Abstract;
using System.Collections.Generic;
using System.Text;
using GameSalesSimulation.Entities;

namespace GameSalesSimulation.Concrete
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Müşteri Eklendi. : " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("Doğrulama ve kayıt başarısız.");
            }
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
