using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1, "Doğukan", "Aslan", "Kayseri"); //Bu şekilde kullanmak istiyorsam constructor da tanımlamam lazım Customer(int Id ...) gibi.
            Customer customer2 = new Customer {CustomerId = 2, FirstName = "Nurettin", LastName = "Yılmaz", City = "Kayseri" };
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer1.FirstName);
            
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            CustomerId = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
