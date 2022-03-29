using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ActionAndFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            //ActionDemo();


            Func<int, int, int> add = Topla;

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return  random.Next(0, 100);
            };
            Console.WriteLine(getRandomNumber());


            Func<int> getRandomNumber2 = () => new Random().Next(1,100);
            Console.WriteLine(getRandomNumber2());


            Console.WriteLine(add(3,7));

            Console.WriteLine(Topla(2,3));

            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() =>
            {
                Find();
            });
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Doğukan", "Nurettin", "Samet" };
            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }

    [Serializable]
    internal class RecordNotFoundException : Exception
    {
        public RecordNotFoundException()
        {
        }

        public RecordNotFoundException(string message) : base(message)
        {
        }

        public RecordNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RecordNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
