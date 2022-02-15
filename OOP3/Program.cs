using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(personalFinanceCreditManager, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager, housingCreditManager, transportCreditManager };

            //applicationManager.MakeACreditPreInformation(credits);
        }
    }
}

//İnterfaceler de o interface i implemente eden classı tutabilir.
