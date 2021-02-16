using CoffeeShop.Entities.Abstract;
using System;

namespace CoffeeShop.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public long IdentityNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
    }
}
