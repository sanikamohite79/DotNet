using System.ComponentModel;
using HR;
namespace SimpleApp;
public class Program
{


    // two types of classes
    //1. Concrete class - Employee, Trainer
    //2. Abstract class - IWorker

    //Entry point function
    public static void Main(string[] args)
    {


        //Polymorphism
        Console.WriteLine("Polymorphism Example:");
       
       //object construction

        IWorker worker = new Employee();
        worker.Work();

        IWorker trainer = new Trainer();

        //Polymorphism
        trainer.Work();
    }
}
 