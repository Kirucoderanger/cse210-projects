using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        Product product1 = new Product(001,"Laptop", (decimal)1200.00, 1);
        Product product2 = new Product(002,"Mouse", (decimal) 25.00, 2);
        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "Provo", "UT", "USA"));
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Product product3 = new Product(003, "Phone", (decimal) 800.00, 1);
        Product product4 = new Product(004, "Charger", (decimal) 20.00, 1);
        Customer customer2 = new Customer("Jane Smith", new Address("456 Elm St", "Salt Lake City", "UT", "USA"));
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order 1 Total Price: ${order1.CalculateTotalCost():F2}");

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order 2 Total Price: ${order2.CalculateTotalCost():F2}");
    }
}