using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (var product in _products)
        {
            totalCost += product.GetTotalPrice();
        }

        totalCost += _customer.LivesInUSA() ? 5 : 35;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();

        foreach (var product in _products)
        {
            packingLabel.AppendLine($"Product Name: {product.Name}, Product ID: {product.Id}");
        }

        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Customer Name: {_customer.Name}\nAddress: {_customer.GetAddress()}";
    }
}

/*public class Product
{
    public string Name { get; private set; }
    public string ProductId { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }

    public Product(string name, string productId, decimal price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return Price * Quantity;
    }
}

public class Customer
{
    public string Name { get; private set; }
    private string _address;
    private string _country;

    public Customer(string name, string address, string country)
    {
        Name = name;
        _address = address;
        _country = country;
    }

    public string GetAddress()
    {
        return _address;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }
}*/