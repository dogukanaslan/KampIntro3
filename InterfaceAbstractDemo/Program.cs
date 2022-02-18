using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2003,3,11), FirstName = "Doğukan", LastName = "Aslan", NationalityId = "22718251468"});
            Console.ReadLine();
        }
    }
}



//Senaryo => 1-)Kahve dükkanları için müşteri yönetimi yapan bir sistem yapm ak istiyoruz.
//           2-)Starbucks ve Nero firması için çalışıyoruz.
//           3-)İki firma da müşterilerini veri tabanına kaydetmek istiyor.
//           4-)Starbucks müşterilerini kaydederken mernis(Kimlik) doğrulaması istiyor ama Nero bunu istemiyor.
//           5-)Starbucks müşterileri için her kahve alımında yıldız kazandırmak istiyor.