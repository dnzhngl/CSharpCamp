using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product p1 = new Product()
            {
                Id = 1,
                Name = "Apple",
                Price = 15,
                Description = "Amasya Apple From Turkey / Amasya",
                UnitsInStock = 40
            };
            Product p2 = new Product()
            {
                Id = 2,
                Name = "Watermelon",
                Price = 40,
                Description = "From Turkey / Diyarbakır",
                UnitsInStock = 50
            };

            Product[] products = new Product[] { p1, p2 };
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name} : {product.Price}$ \nDetails : {product.Description} \n");
            }

            CartManager basketManager = new CartManager();
            basketManager.Add(p1);
            basketManager.Add(p2);

        }
    }
}


// DRY - Don't repeat yourself - Clean code - Best Practice