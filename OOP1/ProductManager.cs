using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi. ");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi. ");
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
//void emir kipidir.Gider işini yapar ve bitirir. Mesela ben 2 tane sayıyı topladım ve çıkan sonucu başka bir şekilde kullanmak istedim örneğin 2 ile çarpmak istedim. Bunu void ile yapamam.
//Bunun için RETURN kullanılır.