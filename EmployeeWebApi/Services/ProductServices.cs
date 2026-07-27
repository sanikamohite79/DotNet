
namespace Service;
using Entitie;
using System.Collections.Generic;

public class ProductServices
{
    public static List<Product> GetAll()
    {
        List<Product> products = new List <Product>();
        products.Add(new Product{Id=23 ,Name="Laptop" ,Price=300000});
        products.Add(new Product{Id=24 ,Name="Mobile" , Price=200000});
        return products;
    }

    public static string Insert()
    {
        Console.WriteLine("New product inserttion Process.");
        return "Product inserted successfully";
    }
}