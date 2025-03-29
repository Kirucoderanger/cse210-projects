using System.Runtime.InteropServices;
public class Product
{
    // Private member variables
    private int _id;
    private string _name;
    private decimal _price;
    private int _quantity;

    // Public constructor
    public Product(int id, string name, decimal price, int quantity)
    {
        _id = id;
        _name = name;
        _price = (decimal)price;
        _quantity = quantity;
    }

    // Public properties for accessing private variables
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    // Assuming this is the Order class definition
/*public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        

        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.Price * product.Quantity;
        }
        return total;
    }

    // Other methods
}*/
    public decimal GetTotalPrice()
    {
        // Assuming this method should calculate the total price of products
        decimal total = _price * _quantity;
        return total;
    }
}
