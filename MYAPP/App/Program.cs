// See https://aka.ms/new-console-template for more information

using EmployeeApp;
using StudentApp;
using BankApp;

public class Program
{
    public static void Main (string[] args)      //main methoid
    {
        Employee e1=new Employee();          //create object
        e1.display();

        Student s=new Student();
        s.show();

Console.Write("Enter Interest Amount: ");
int interest = int.Parse(Console.ReadLine());

Console.Write("Enter Saving Amount: ");
int saving = int.Parse(Console.ReadLine());

Bank bank = new Bank(interest, saving);

bank.Display();
    }
}