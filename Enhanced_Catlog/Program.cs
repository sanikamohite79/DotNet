using System;
class Program
{
    static void Main()
    {
        Catalog catalog = new Catalog();

        catalog.AddProduct(new Product(101, "Mouse", 500));
        catalog.AddProduct(new Product(102, "Keyboard", 800));
        catalog.AddProduct(new Product(103, "Monitor", 7000));
        catalog.AddProduct(new Product(104, "Laptop", 55000));

        // ✅ Using indexer by index
        Console.WriteLine(catalog[0]);

        // ✅ Using indexer by product name
        Console.WriteLine("Search by name (Monitor): " + catalog["Monitor"]);

        // ✅ Sort products by price descending
        catalog.SortByPrice(false);

        Console.WriteLine("\nProducts sorted by price (Desc):");
        for (int i = 0; i < catalog.Count; i++)
            Console.WriteLine(catalog[i]);

        // ✅ Remove a product
        catalog.RemoveProduct(102);
        Console.WriteLine("\nAfter removing Keyboard:");
        for (int i = 0; i < catalog.Count; i++)
            Console.WriteLine(catalog[i]);
    }
}