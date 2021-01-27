using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            Customer customer1 = new Customer
            {
                Id = 1,
                Firstname = "Ayşe",
                Lastname = "Sevimli",
                DateOfJoined = DateTime.Now
            };
            Customer customer2 = new Customer
            {
                Id = 2,
                Firstname = "Veli",
                Lastname = "Gülümser",
                DateOfJoined = DateTime.Now
            };
            Customer customer3 = new Customer
            {
                Id = 3,
                Firstname = "Can",
                Lastname = "Sever",
                DateOfJoined = DateTime.Now
            };


            static void AddCustomer(CustomerManager customerManager, Customer customer)
            {
                customerManager.Add(customer);
            }

            static void GetAllCustomer(CustomerManager customerManager)
            {
                var customerList = customerManager.GetAll();
                foreach (var customerInfo in customerList)
                {
                    Console.WriteLine(customerInfo);
                }
            }
            static void DeleteCustomer(CustomerManager customerManager, int customerId)
            {
                customerManager.Delete(customerId);
            }

            static void UpdateCustomer(CustomerManager customerManager, Customer customer)
            {
                var customerInfo = customerManager.Update(customer);
                Console.WriteLine(customerInfo);
            }

            AddCustomer(customerManager, customer1);
            AddCustomer(customerManager, customer2);
            AddCustomer(customerManager, customer3);
            GetAllCustomer(customerManager);
            DeleteCustomer(customerManager, customer3.Id);

            customer2.Lastname = "Gülümsemez";
            UpdateCustomer(customerManager, customer2);
        }
    }
}
