using NullableApp;
class Program
{
    static void Main(string[] args)
    {
        DatabaseReader dr = new DatabaseReader();

        // Reading a nullable int
        int? i = dr.GetIntFromDatabase() ?? 50;     //if there is not assign 50 there print value is undefined.
        if (i.HasValue)
            Console.WriteLine("Value of 'i' is: {0}", i.Value);
        else
            Console.WriteLine("Value of 'i' is undefined.");

        // Reading a nullable bool
        bool? b = dr.GetBoolFromDatabase();

        // Using the null-coalescing operator to provide a default
        int? myData = dr.GetIntFromDatabase() ?? 100;
        Console.WriteLine("Value of myData: {0}", myData.Value);
    }

    
}