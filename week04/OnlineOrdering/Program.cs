using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");

        Customer customer1 = new Customer("John Doe", address1);

        Product product1 = new Product("C# Book", "B001", 29.99f, 2);
        Product product2 = new Product("Laptop Stand", "S002", 49.99f, 1);
        Product product3 = new Product("USB-C Cable", "C003", 9.99f, 3);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine($"Total Price is : ${order1.GetTotalPrice()}");

        Console.WriteLine("\n" + order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

    }
}