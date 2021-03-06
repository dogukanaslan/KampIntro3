using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //dortIslem.Topla(5, 3);
            //dortIslem.Topla2();

            var type = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(dortIslem.Topla(2, 6));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(type,6,7);

            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null) );

            var metotlar = type.GetMethods();
            foreach (var info in metotlar)
            {
                Console.WriteLine("Metot Adı : {0}", info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre Adı : {0}", parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute : {0}", attribute.GetType().Name);
                }
            }
            Console.ReadLine();

        }
    }
    public class DortIslem
    {
       private int _sayi1;
       private int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public DortIslem()
        {

        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
    public class MethodNameAttribute : Attribute
    {
        private string _tableName;
        public MethodNameAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
