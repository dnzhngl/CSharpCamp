using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();

        public void Add(Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine("Customer added.");
        }
        public List<string> GetAll()
        {
            var customerList = new List<string>();
            foreach (var customer in customers)
            {
                customerList.Add($"{customer.Firstname} {customer.Lastname} - Katıldığı Gün: {customer.DateOfJoined}");
            }
            return customerList;
        }
        public void Delete(int id)
        {
            var customer = customers.Find(c => c.Id == id);
            customers.Remove(customer);
            Console.WriteLine("Customer deleted.");
        }
        public string Update(Customer updatedcustomer)
        {
            var customer = customers.Find(c => c.Id == updatedcustomer.Id);
            customer = updatedcustomer;
            Console.WriteLine("Customer updated");
            return ($"{customer.Firstname} {customer.Lastname} - Katıldığı Gün: {customer.DateOfJoined}");
        }
    }
}
