

 using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee("Vedant", 50000),
            new Employee("Abhay", 40000),
            new Employee("Shubham", 60000)
        };

        Console.WriteLine("Before Sorting:");

        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp.Name + " " + emp.Salary);
        }

        employees.Sort(new NameComparer());

        Console.WriteLine("\nAfter Sorting by Name:");

        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp.Name + " " + emp.Salary);
        }


         // Sort by Salary
        employees.Sort(new SalaryComparer());

        Console.WriteLine("\nSorted by Salary:");

        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp.Name + " " + emp.Salary);
        }
    }
}