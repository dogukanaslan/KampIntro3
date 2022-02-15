using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> isimler = new MyDictionary<int, string>();
            isimler.Add(311, "Doğukan Aslan");
            isimler.Add(708, "Ayşenur Aslan");
            isimler.Add(916, "Nurettin Yılmaz");
            isimler.Add(475, "Enes Küçük");
            isimler.Add(851, "Süleyman Biçer");
            isimler.Add(753, "Buse Karaca");
            isimler.Add(542, "Muhammed Karaman");
            Console.WriteLine(isimler.Count);
            for (int i = 0; i < isimler.Count; i++)
            {
                isimler.Value(i);
            }
        }
    }
}
