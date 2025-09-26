using System;
using System.Collections.Generic;

namespace OnlineOrderingSystem
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address ShippingAddress { get; set; }
        public List<Order> Orders { get; private set; }

        public Customer(int customerId, string firstName, string lastName, string email, Address shippingAddress)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            ShippingAddress = shippingAddress;
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}