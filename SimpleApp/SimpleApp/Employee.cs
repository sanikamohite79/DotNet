namespace HR;

//inheritance of interface IWorker

//abstraction

//Inheritance 
public class Employee : IWorker
{
    
    //encapsulation
    private string name;
    private int age;

    //override
    public  void Work()
    {
        Console.WriteLine("Employee is working.");
    }
}