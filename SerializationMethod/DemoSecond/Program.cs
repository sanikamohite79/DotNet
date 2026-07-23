
using DemoSecond;
using System.Text.Json;

List <Employee> employees=new List <Employee>()
{
    new Employee{Id=101,Salary=200000},
     new Employee{Id=101,Salary=200000},
      new Employee{Id=101,Salary=200000}
};

RepositoryManager manager = new RepositoryManager();

manager.Serialize(employees, "employees.json");

List<Employee> loadedEmployees =
    manager.DeSerialize("employees.json");