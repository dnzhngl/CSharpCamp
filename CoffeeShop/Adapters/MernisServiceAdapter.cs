using CoffeeShop.Abstract;
using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace CoffeeShop.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();

            return client.TCKimlikNoDogrulaAsync(customer.IdentityNo, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DOB.Year).IsCompletedSuccessfully;
        }
    }
}
