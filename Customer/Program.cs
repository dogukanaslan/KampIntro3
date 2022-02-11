using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Nurettin";
            customer1.CustomerSecondName = "Yılmaz";
            customer1.CustomerAge = 19;
            customer1.CustomerId = "15485027385";

            Customer customer2 = new Customer();
            customer2.CustomerName = "Doğukan";
            customer2.CustomerSecondName = "Aslan";
            customer2.CustomerAge = 19;
            customer2.CustomerId = "22718251468";

            Customer customer3 = new Customer();
            customer3.CustomerName = "Türkan";
            customer3.CustomerSecondName = "Aslan";
            customer3.CustomerAge = 57;
            customer3.CustomerId = "54292205896";

            Customer[] customers = new Customer[] {customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            Console.WriteLine(" ");
            customerManager.Delete(customer2);
            Console.WriteLine(" ");
            customerManager.List(customers);
        }
    }
}
