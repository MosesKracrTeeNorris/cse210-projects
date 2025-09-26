using System;

class Program
{
    static void Main(string[] args)
    {
       
   
        // Customers and their addresses
        Address addr1 = new Address("1647 Califonia", "CA", " 1107 Utah", "UT", "North Dakota", "USA");
        Customer cust1 = new Customer("Sibey B. Norris", addr1);

        Address addr2 = new Address("730 3rd Street Sinkor", "Saye Town", "1000 Monrovia", "10 Liberia");
        Customer cust2 = new Customer("Famata Jalloh", addr2);

        Address addr3 = new Address("1040 Cheeseman Avenue, 18th Street Sinkor", "1000 Monrovia", "10 Liberia");
        Customer cust3 = new Customer("Tetta George", addr3);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Keyboard", "Keyboard-001", 7, 4));
        order1.AddProduct(new Product("Mouse", "Mouse-001", 5, 6));

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Perfume", "Perfume-006", 10, 8));
        order2.AddProduct(new Product("Hair Greece", "HGreece-004", 12, 6));

        Order order3 = new Order(cust3);
        order3.AddProduct(new Product("Hair Conditional", "HC-005", 10, 5));
        order3.AddProduct(new Product("Powder", "PD-003", 15, 8));

        order1.DisplayOrder();
        order2.DisplayOrder();
        order3.DisplayOrder();
    }
}