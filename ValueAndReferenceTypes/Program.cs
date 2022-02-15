using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Doğukan";
            person2 = person1;
            person1.FirstName = "Nurettin";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            Employee employee = new Employee();
            employee.FirstName = "Enes";
            Person person3 = employee;
            Console.WriteLine(person3.FirstName);
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //base class : Person
    class Customer : Person
    {
        public int CreditCardNumber{ get; set; }
    }
    class Employee : Person
    {
        public int EmployeeId { get; set; }
    }
}

//int,decimal.float.double,bool = değer tip
// array,class,interface = referans tip
//Customer  ve Employee de bir Person olduğu için referansı aktarabiliyorum ama Customer ile Employee arasında aktaramıyorum.