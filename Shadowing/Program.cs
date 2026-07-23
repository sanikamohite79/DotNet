
using Shadowing;
class Program
{
    static void Main()
    {
        SalesEmployee sper = new SalesEmployee();

        double salary = sper.CalculateSalary();

        Console.WriteLine(salary);
    }
}