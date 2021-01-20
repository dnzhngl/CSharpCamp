using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //ProductService olarak adlandırıldığıda olur.
    class ProductManager //Ürünle ilgili CRUD operasyonları burada yer alır.
    {
        // encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.Name + " güncellendi.");
        }

        
    }
}
