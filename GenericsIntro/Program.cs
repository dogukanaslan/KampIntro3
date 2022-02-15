using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler1 = new List<string>();
            isimler1.Add("Nurettin");
            isimler1.Add("Enes");
            isimler1.Add("Kerem");
            isimler1.Add("İbrahim");
            isimler1.Add("Muhammet");
            isimler1.Add("Ahmet");
            Console.WriteLine(isimler1.Count);

            MyList<string> isimler2 = new MyList<string>();
            isimler2.Add("Çağrı");
            isimler2.Add("Ali");
            isimler2.Add("Gamze");
            isimler2.Add("Ayşenur");
            isimler2.Add("Süleyman");
            isimler2.Add("Mert");
            Console.WriteLine(isimler2.Count);
        }
    }
}
//Buradaki string T oluyor.