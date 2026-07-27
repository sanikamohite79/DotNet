
namespace WebApiDemo;

using  Entities;
using System.Collections.Generic;

public class EmployeeService
{
    public static List<Employee> GetAll()
    {
        List <Employee> employee = new List <Employee>();
        employee.Add(new Employee{Id=1 ,Name="Sanika", Salary=20000});
         employee.Add(new Employee{Id=2 ,Name="Naina", Salary=30000});
          employee.Add(new Employee{Id=3 ,Name="Roshan", Salary=40000});
          return employee;

    }

    public static string  Insert()
    {
        Console.WriteLine("New Employee inserttion process");
        return "Employee inserted successfully";
    }
}