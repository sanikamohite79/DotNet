
using IClonableApp;
class Program
{
    static void Main()
    {
        Person original = new Person { Name = "Amit", Age = 30 };
        Person clone = (Person)original.Clone();

        Console.WriteLine(clone.Name); // Output: Amit
        Console.WriteLine(clone.Age);  // Output: 30
    }
}