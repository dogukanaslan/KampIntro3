using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] {"Java", "Phyton", "C#", "C++", "JavaScript", "SQL", "CSS" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti.");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
