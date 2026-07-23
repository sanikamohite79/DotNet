namespace SingleArray;

public class Product
{
    public int Id;
    public string Name;
    public double Price;

    // Constructor
    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product[] products = new Product[5]
        {
            new Product(101, "Mouse", 500),
            new Product(102, "Keyboard", 800),
            new Product(103, "Monitor", 7000),
            new Product(104, "Laptop", 55000),
            new Product(105, "Pen Drive", 700)
        };

        foreach (Product p in products)
        {
            Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}");
        }
    }
}