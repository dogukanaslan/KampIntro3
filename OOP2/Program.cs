using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndivisualCustomer customer1 = new IndivisualCustomer();
            customer1.Id = 1;
            customer1.CustomnerNumber = "12345";
            customer1.IdentityNumber = "12345678910";
            customer1.Name = "Doğukan";
            customer1.SurName = "Aslan";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomnerNumber = "54321";
            customer2.TaxNumber = "123456789";
            customer2.CompanyName = "Tesla";
        }
    }
}
