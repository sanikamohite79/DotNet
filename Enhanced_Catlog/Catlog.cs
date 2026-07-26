
public class Catalog
{
    private List<Product> products = new List<Product>();

    // ✅ Indexer using integer (like array)
    public Product this[int index]
    {
        get
        {
            if (index >= 0 && index < products.Count)
                return products[index];
            throw new IndexOutOfRangeException("Invalid index!");
        }
        set
        {
            if (index >= 0 && index < products.Count)
                products[index] = value;
            else
                throw new IndexOutOfRangeException("Invalid index!");
        }
    }

    // ✅ Overloaded Indexer using Product Name
    public Product this[string name]
    {
        get
        {
            return products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }

    // ✅ Add product
    public void AddProduct(Product p)
    {
        products.Add(p);
    }

    // ✅ Remove product by ID
    public bool RemoveProduct(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            products.Remove(product);
            return true;
        }
        return false;
    }

    // ✅ Search by Name
    public Product SearchByName(string name)
    {
        return products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    // ✅ Sorting
    public void SortByPrice(bool ascending = true)
    {
        products = ascending
            ? products.OrderBy(p => p.Price).ToList()
            : products.OrderByDescending(p => p.Price).ToList();
    }

    public void SortByName()
    {
        products = products.OrderBy(p => p.Name).ToList();
    }

    public int Count => products.Count;
}