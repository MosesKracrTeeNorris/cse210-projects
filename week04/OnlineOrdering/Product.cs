using System;

namespace OnlineOrderingSystem
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public Product(int productId, string name, string description, decimal price, int stockQuantity)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public void DecreaseStock(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                throw new InvalidOperationException("Not enough stock available.");
            }
        }

        public void IncreaseStock(int quantity)
        {
            StockQuantity += quantity;
        }
    }
}