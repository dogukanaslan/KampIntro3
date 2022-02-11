using System;

namespace KampIntro3
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int kullaniciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kullaniciSayisi);
            Console.WriteLine(faizOrani);

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi Oku");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
        }
    }
}
