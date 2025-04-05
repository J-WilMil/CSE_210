using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Elm St", "New York", "NY", "USA");
        
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "LPT123", 999.99, 1));

        order1.AddProduct(new Product("Mouse", "MSE456", 25.50, 2));

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        Customer customer2 = new Customer("Jane Smith", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Monitor", "MON789", 199.99, 1));

        order2.AddProduct(new Product("Keyboard", "KBD101", 49.99, 1));

        List<Order> orders = new List<Order> { order1, order2 };
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}\n");
        }
    }
};