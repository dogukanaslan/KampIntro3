using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            switch (number)
            {
                case 1:
                    Console.WriteLine("Durum 1");
                    break;
                case 2:
                    Console.WriteLine("Durum 2");
                    break;
                default:
                    Console.WriteLine("Varsayılan durum");
                    break;
            }
        }
    {
