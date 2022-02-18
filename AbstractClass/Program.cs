using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TemelSinif sinif = new TuretilmisSinif();
            sinif.Method1();
            sinif.Method2();
        }
    }
    public abstract class Month
    {
        public int HowManyHoursAreTheDays(Month month)
        {
            return 24;;
        }
        public virtual int HowManyDaysIsIt()
        {
            return 31;
        }
        public abstract int WhatMonthOfTheYearIsIt();
    }
    public class January : Month
    {
        public override int WhatMonthOfTheYearIsIt()
        {
            return 1;
        }
    }
    public class February : Month
    {
        public override int WhatMonthOfTheYearIsIt()
        {
            return 2;
        }
    }
    public class March : Month
    {
        public override int WhatMonthOfTheYearIsIt()
        {
            return 3;
        }
    }
}
//Arayüzlerde sadece metot bildirimi yapılabilirken Abstract sınıflarda hem metot bildirimi yapılabilir hem de metot tanımlanabilir.
//Eğer bir metot tüm türetilmiş sınıflarda aynı şekilde tanımlanıyorsa o metodu abstract sınıf içerisinde standart bir metot tanımlar gibi tanımlarız.
//Normal sınıflardan “new()” anahtar sözcüğü ile nesneler oluşturulabilir ancak Abstract sınıflar tamamen kalıtım amaçlı geliştirildiğinden Abstract sınıflardan nesne oluşturulamaz.
//Bir sınıfa sadece bir tane Abstract sınıf inherit edilebilir ancak aynı sınıfa birden fazla arayüz implement edilebilir.
//Ancak bir Abstract sınıfa, başka bir Abstract sınıfı inherit ederek bu kısıtı kaldırmak mümkün.
//Eğer bir metot bir çok türetilmiş sınıfta aynı şekilde tanımlanıyor iken sadece bir kaçında değişik şekilde tanımlanıyorsa o metot abstract sınıf içerisinde virtual olarak tanımlanır.
//Eğer bir metot tüm türetilmiş sınıflarda farklı şekilde tanımlanıyorsa o metodun abstract sınıf içerisinde sadece bildirimi yapılır.
