using System.Collections.Generic;

public class Catalog
{
    private List<Product> products = new List<Product>();

    // Indexer (like array access)
    public Product this[int index]
    {
        get 
        {
            if (index >= 0 && index < products.Count)
                return products[index];
            else
                throw new IndexOutOfRangeException("Invalid product index!");
        }
        set 
        {
            if (index >= 0 && index < products.Count)
                products[index] = value;
            else
                throw new IndexOutOfRangeException("Invalid product index!");
        }
    }

    // Add product to catalog
    public void AddProduct(Product p)
    {
        products.Add(p);
    }

    // Property to get number of products
    public int Count
    {
        get { return products.Count; }
    }
}