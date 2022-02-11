using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Elma";
            product1.Price = 12;
            product1.Detail = "Amasya Elması";

            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.Price = 20;
            product2.Detail = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Detail);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("---------------Methods----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
        }
    }
}

//Tekrar tekrar kullanılabilirliği sağlar.
//Encapsulation
