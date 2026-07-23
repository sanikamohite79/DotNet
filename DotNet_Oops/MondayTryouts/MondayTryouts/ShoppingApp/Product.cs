
namespace ECommerce;

public class Product
{
    private string name;
    private decimal price;
    private int quantity;
    private string size;

    public Product(string name, decimal price, int quantity,string size)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
        this.size = size;
    }

    public string GetName()
    {
        return name;
    }

    public decimal GetPrice()
    {
        return price;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public string Getsize()
    {
        return size;
    }
    public void Display()
    {
        Console.WriteLine($"Product: {name}, Price: {price:C}, Quantity: {quantity}, size: {size}");
    }
}
