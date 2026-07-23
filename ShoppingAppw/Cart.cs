namespace ECommerce;

public class Cart
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine("Product added successfully.");
    }

    public void RemoveProduct(string productName)
    {
        Product productToRemove =
            products.Find(
                p => p.name.Equals(
                    productName,
                    StringComparison.OrdinalIgnoreCase));

        if (productToRemove != null)
        {
            products.Remove(productToRemove);
            Console.WriteLine("Product removed successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void DisplayProduct()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("Cart is Empty.");
            return;
        }

        Console.WriteLine("\nProducts in Cart:");

        foreach (Product product in products)
        {
            Console.WriteLine(
                $"Name={product.name}, Price={product.Price}, Quantity={product.Quntity}");
        }

         Console.WriteLine("Update Produst List:");

     foreach(Product product in products)
     {
        Console.WriteLine($"Name={product.name},  Price={product.Price},  Quntity={product.Quntity}");
     }
    }
}