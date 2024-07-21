using System;

public class Program
{
    public static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "US");
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        Address address3 = new Address("111 Main St", "Thistown","Utah", "US");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3  =new Customer("Ethem Deli", address3);

        // Create orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);

        // Create products
        Product product1 = new Product("Laptop", "A123", 999.99f, 1);
        Product product2 = new Product("Mouse", "B456", 19.99f, 2);
        Product product3 = new Product("Keyboard", "C789", 49.99f, 1);

        // Add products to orders
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order3.AddProduct(product1);
        order3.AddProduct(product2);
        order3.AddProduct(product3);

        // Display order details
        Console.WriteLine($"Order 1 Total Cost: {order1.CalculateTotalCost()}");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine();

        Console.WriteLine($"Order 2 Total Cost: {order2.CalculateTotalCost()}");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine();

        Console.WriteLine($"Order 3 Total Cost: {order3.CalculateTotalCost()}");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
    }
}
