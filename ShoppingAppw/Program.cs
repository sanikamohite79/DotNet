
namespace ECommerce;

public class Program
{
    public static void Main (String [] args)
    {
        Product p=new Product( "Laptop",30000,10);
        p.Display();

        Console.WriteLine();


        // List<Product> products =new List<Product>();
        //  products.Add(new Product( "Mobile", 20000,20));
        // products.Add(new Product("Headphones", 3000,30));
        //  products.Add(new Product("Mouse", 300,5));
        //   products.Add(new Product("Buds", 3000,9));

        // Console.WriteLine("Product List:");


    //     foreach(Product product in products)
    //  {
    //         Console.WriteLine($"Name  =  {product.name}, Price ={product.Price}, Quantity={product.Quntity}");
    //  }

    //  Console.WriteLine();


//      Console.WriteLine("Enter Product Name TO Remove: ");
//      string productName=Console.ReadLine();


//      Console.WriteLine();


    
//         Product productToRemove =
//             products.Find(p => p.name.Equals(productName, StringComparison.OrdinalIgnoreCase));


// if(productToRemove != null) 
// {
//     products.Remove(productToRemove);
//     Console.WriteLine("Product removed successfully.");
// }
// else
// {
//     Console.WriteLine("Product not Found");

// }

Cart cart=new Cart();
while(true)
{
    Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Display Product");
            Console.WriteLine("4. Exit");


            Console.WriteLine("Enter choice:");
            int choice=Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                Console.WriteLine("Enter Product Name:");
                string name=Console.ReadLine();

                Console.WriteLine("Emter Price:");
                int price=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Quantity: ");
                    float quantity = Convert.ToSingle(Console.ReadLine());


                    Product P = new Product(name, price, quantity);

                    cart.AddProduct(P);
                    break;


                    case 2:

                     Console.Write("Enter Product Name To Remove: ");
                    string productName = Console.ReadLine();

                    cart.RemoveProduct(productName);
                    break;


                      case 3:

                    cart.DisplayProduct();
                    break;

                      case 4:

                    return;

                    case 5:
                    Console.WriteLine("Updated List:");
                    break;

                default:

                    Console.WriteLine("Invalid Choice");
                    break;
            }
}



    }
}
    

// Console.WriteLine();



    //  Console.WriteLine("Update Procust List:");

    //  foreach(Product product in products)
    //  {
    //     Console.WriteLine($"Name={product.name},  Price={product.Price},  Quntity={product.Quntity}");
    //  }
      
//     }
//  }