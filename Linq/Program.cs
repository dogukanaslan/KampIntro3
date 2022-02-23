using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Telefon"},
                new Category{CategoryId = 2, CategoryName = "Bilgisayar"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId = 1, ProductName = "Acer", QuantityPerUnit = "16 GB Ram", UnitPrice = 10500, UnitsInStock = 10},
                new Product{ProductId=2, CategoryId = 2, ProductName = "Samsung", QuantityPerUnit = "Exynos İşlemci", UnitPrice = 6500, UnitsInStock = 20},
                new Product{ProductId=3, CategoryId = 2, ProductName = "Xiaomi", QuantityPerUnit = "Qualcomm İşlemci", UnitPrice = 5000, UnitsInStock = 1},
                new Product{ProductId=4, CategoryId = 2, ProductName = "Apple", QuantityPerUnit = "A15 Bionics", UnitPrice = 12400, UnitsInStock = 7},
                new Product{ProductId=5, CategoryId = 1, ProductName = "Monster", QuantityPerUnit = "RTX 3050Tİ Ekran Kartı", UnitPrice = 8000, UnitsInStock = 12}
            };

            var result = products.Where(p => p.UnitPrice > 5000);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        } 
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
