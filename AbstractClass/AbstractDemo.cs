using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class TemelSinif
    {
        public void Method1()
        {
            Console.WriteLine("Abstract sınıf içerisinde tanımlanmış metot.");
        }
        public abstract void Method2();
    }
    public class TuretilmisSinif : TemelSinif
    {
        public override void Method2()
        {
            Console.WriteLine("Türetilmiş sınıf içerisinde tanımlanmış metot.");
        }
    }
}
