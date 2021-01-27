using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {   
        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " sepete eklendi");
        }

        public void Add(string name, double price, string description, int unitsInStock) 
        {
            Console.WriteLine(name + " sepete eklendi");
        }
    }
}
