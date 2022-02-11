using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryOperator
{
    class TernaryOperator
    {
        static void Main(string[] args)
        {
            string kullaniciAdi = " ";
            string sifre = " ";
            Console.WriteLine("Kullanıcı Adını Girin");
            kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreyi Girin");
            sifre = Console.ReadLine();

            string durum = (kullaniciAdi == "admin" && sifre == "12345") ? "Giriş Başarılı" : "Kullanıcı Adı Veya Şifre Hatalı";       }
    }
}
