using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product
            {
                Id = 1,
                Name = "Masa",
                UnitPrice = 500,
                UnitsInStock = 3,
                CategoryId = 2
            };
            Product p2 = new Product
            {
                Id = 2,
                Name = "Kalem",
                UnitPrice = 35,
                UnitsInStock = 5,
                CategoryId = 5
            };

            //PascalCase    //camelCase
            // Stack                        // Heap
            ProductManager productManager = new ProductManager();
            productManager.Add(p1);
            productManager.Add(p2);
            Console.WriteLine(p1.Name);

        }
    }
}
