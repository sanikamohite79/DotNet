using IndexerProgram;
class Program
{
    static void Main()
    {
        Catalog catalog = new Catalog();

        // Adding products
        catalog.AddProduct(new Product(101, "Mouse", 500));
        catalog.AddProduct(new Product(102, "Keyboard", 800));
        catalog.AddProduct(new Product(103, "Monitor", 7000));

        // Access using indexer
        Console.WriteLine("First Product: " + catalog[0]);

        // Modify using indexer
        catalog[1] = new Product(202, "Mechanical Keyboard", 1500);

        Console.WriteLine("\nAll Products:");
    }
}