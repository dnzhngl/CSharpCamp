using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer); //Save to db
    }
}
