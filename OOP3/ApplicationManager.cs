using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void MakeAnApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }
        public void MakeACreditPreInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}

//bir işi birden fazla elemanla yapacaksan list oluşturacakasın. Örneğin aynı anda 2 kredi hesaplama gibi veya aynı anda 3 tane loglama yapmak gibi.
