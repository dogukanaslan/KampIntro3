using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi : " + customer.CustomerName + " " + customer.CustomerSecondName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi : " + customer.CustomerName + " " + customer.CustomerSecondName);
        }

        public void List(Customer[] customers)
        {
            Console.WriteLine("Müşteriler Listelendi : ");
            Console.WriteLine("-------------------");

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerName);
                Console.WriteLine(customer.CustomerSecondName);
                Console.WriteLine(customer.CustomerAge);
                Console.WriteLine(customer.CustomerId);
                Console.WriteLine("-------------------");
            }
        }
    }
}
