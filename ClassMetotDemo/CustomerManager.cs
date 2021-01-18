using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> Customers = new List<Customer>();

        public void Add(Customer customer)
        {
            Customers.Add(customer);
            Console.WriteLine("Customer added.");
        }
        public List<string> GetAll()
        {
            var customerList = new List<string>();
            foreach (var customer in Customers)
            {
                customerList.Add($"{customer.Firstname} {customer.Lastname} - Katıldığı Gün: {customer.DateOfJoined}");
            }
            return customerList;
        }
        public void Delete(int id)
        {
            var customer = Customers.Find(c => c.Id == id);
            Customers.Remove(customer);
            Console.WriteLine("Customer deleted.");
        }
        public string Update(Customer updatedcustomer)
        {
            var customer = Customers.Find(c => c.Id == updatedcustomer.Id);
            customer = updatedcustomer;
            Console.WriteLine("Customer updated");
            return ($"{customer.Firstname} {customer.Lastname} - Katıldığı Gün: {customer.DateOfJoined}");
        }
    }
}
