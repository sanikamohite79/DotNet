using MyLibrary;

public class HelloWorld
{
    public static void Main(string[] args)
    {


        
var name = args.Length > 0 ? args[0] : "World";

Console.WriteLine(Greeter.Hello(name));

        Console.WriteLine("Parameter count = {0}", args.Length);
        Console.WriteLine("Hello {0}", args[0]);
    }
}


