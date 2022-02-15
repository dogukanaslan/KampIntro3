using System;
using System.Collections.Generic;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Student = new Dictionary<int, string>();
            Student.Add(311, "Doğukan Aslan");
            Student.Add(708, "Nurettin Yılmaz");
            Student.Add(918, "Ayşenur Aslan");
            Student.Add(310, "Enes Küçük");
            Student.Add(768, "Süleyman Biçer");


            Console.WriteLine("İsimlerin Numarasını Giriniz");
            int No = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Student[No]);
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }
        }
    }
}
