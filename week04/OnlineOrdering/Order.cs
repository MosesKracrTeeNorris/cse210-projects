using System;
using System.Collections.Generic;

namespace OnlineOrderingSystem
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; private set; }
        public decimal TotalAmount { get; private set; }
        public string Status { get; set; } // e.g., "Pending", "Shipped", "Delivered"

        public Order(int orderId, int customerId)
        {
            OrderId = orderId;
            CustomerId = customerId;
            OrderDate = DateTime.Now;
            Products = new List<Product>();
            TotalAmount = 0m;
            Status = "Pending";
        }

        public void AddProduct(Product product, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Products.Add(product);
            }
            TotalAmount += product.Price * quantity;
        }

        public void CalculateTotal()
        {
            TotalAmount = 0m;
            foreach (var product in Products)
            {
                TotalAmount += product.Price;
            }
        }
    }
}