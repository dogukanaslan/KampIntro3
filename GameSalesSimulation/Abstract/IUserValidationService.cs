using GameSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
