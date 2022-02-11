using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Doğukan", "Nurettin", "Enes", "Kerem" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //UsingSystemCollectionsGeneric e basılacak.
            //Listlerin arraylerden farkı arraylerde referansın içindeki eleman sayısı neyse onu yazar.Elemanlar normalde veri kaynağından geleceği için sonradan eleman eklemek istediğinde ekleyemezsin.
            //List sayesinde listeye sonradan fazladan eleman ekleyebilirsin.

            List<string> isimler2 = new List<string> { "Doğukan", "Nurettin", "Enes", "Kerem" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
