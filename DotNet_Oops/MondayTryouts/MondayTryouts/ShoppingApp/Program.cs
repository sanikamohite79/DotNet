namespace  ECommerce;

public class Program
{
    public static void Main(string[] args)
    {

        //Menu driven ECommerce application
        List<Product> products = new List<Product>();//Creates an empty list that can store multiple products.
        products.Add(new Product("Laptop", 1000, 1,"14cm"));
        products.Add(new Product("Smartphone", 500, 2,"5cm"));
        products.Add(new Product("Headphones", 100, 3," 15cm "));
        products.Add(new Product("Keyboard", 50, 4, "20cm"));

        Cart cart = new Cart();
        while (true)//infinite loop -Runs forever until the user chooses Exit.
        {
            Console.WriteLine("1. Add product to cart");
            Console.WriteLine("2. Remove product from cart");
            Console.WriteLine("3. Display cart");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Available products:");
                    for (int i = 0; i < products.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {products[i].GetName()} - {products[i].GetPrice():C} - Quantity: {products[i].GetQuantity()} -{products[i].Getsize()}");
                    }
                    Console.Write("Enter the product number to add to cart: ");
                    int productNumberToAdd = Convert.ToInt32(Console.ReadLine());
                    if (productNumberToAdd >= 1 && productNumberToAdd <= products.Count)
                    {
                        cart.AddProduct(products[productNumberToAdd - 1]);// because indexing starts from 0.
                        Console.WriteLine($"{products[productNumberToAdd - 1].GetName()} added to cart.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid product number.");
                    }
                    break;

                case 2:
                    cart.DisplayCart();
                    Console.Write("Enter the product name to remove from cart: ");
                    string productNameToRemove = Console.ReadLine();//read user input
                    Product productToRemove = products.Find(p => p.GetName().Equals(productNameToRemove, StringComparison.OrdinalIgnoreCase));//p = Laptop   , laptop=Equals(laptop)==true. then remove object from list.
                    //StringComparison.OrdinalIgnoreCase using this because campaire string . sometimes spelling mistecks, like LaPTop,lapTOP . 
                    if (productToRemove != null)
                    {
                        cart.RemoveProduct(productToRemove);
                        Console.WriteLine($"{productToRemove.GetName()} removed from cart.");
                    }
                    else
                    {
                        Console.WriteLine("Product not found in cart.");
                    }
                    break;

                case 3:
                    cart.DisplayCart();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
  
    }
}



// Power of C++
// Simplicity of Java
// Productivity of Python
// Everything inside C#
