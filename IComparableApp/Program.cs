using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Vedant", Salary = 50000 },
            new Employee { Name = "Abhay", Salary = 40000 },
            new Employee { Name = "Shubham", Salary = 60000 }
        };

        Console.WriteLine("Before Sorting:");

        foreach (Employee emp in employees)
        {
            Console.WriteLine($"{emp.Name} - {emp.Salary}");
        }

        employees.Sort();

        Console.WriteLine("\nAfter Sorting:");

        foreach (Employee emp in employees)
        {
            Console.WriteLine($"{emp.Name} - {emp.Salary}");
        }
    }
}