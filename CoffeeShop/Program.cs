using CoffeeShop.Abstract;
using CoffeeShop.Adapters;
using CoffeeShop.Concrete;
using CoffeeShop.Entities;
using System;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager( new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DOB = new DateTime(1990,1,1),
                FirstName = "Salih",
                LastName = "Sağsalim",
                IdentityNo = 12345678910
            });
            Console.ReadLine();
        }
    }
}
