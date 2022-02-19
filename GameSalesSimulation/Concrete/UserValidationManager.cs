using GameSalesSimulation.Abstract;
using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2003 && gamer.FirstName == "Doğukan" && gamer.LastName == "Aslan" && gamer.NationalityId == "22718251468" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
