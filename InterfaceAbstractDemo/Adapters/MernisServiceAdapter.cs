using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MenrisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public object result { get; private set; }

        public bool CheckIfRealPerson(Customer customer)
        {
            MenrisServiceReference.KPSPublicSoapClient client = new MenrisServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId,customer.FirstName.ToUpper(),customer.LastName.ToUpper(),customer.DateOfBirth.Year);
        }
    }
}
