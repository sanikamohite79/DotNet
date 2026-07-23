

namespace IndexerProgram;
// namespace Product;

public class Catlog
{
    
    private List<Product> products = new List<Product>();

    public Product this[int index]
    {
        get
        {
            return products[index];
        }
        set
        {
            products[index]=value;
        }
    }

    public void AddProduct(Product p)
    {
        products.Add(p);
    }


}