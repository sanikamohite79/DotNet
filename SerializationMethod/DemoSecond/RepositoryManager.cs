
namespace DemoSecond;

using System.Text.Json;

public class  RepositoryManager

{
    public void Serialize(List<Employee> employee, string fileName)
    {
       string employeeJson=JsonSerializer.Serialize(employee) ;
       File.WriteAllText(fileName,employeeJson);
       Console.WriteLine("Employee saved successfullu");
    }

public List<Employee> DeSerialize(string fileName)
{
    string jsonString = File.ReadAllText(fileName);

      List<Employee> employees =
            JsonSerializer.Deserialize<List<Employee>>(jsonString)!;

            Console.WriteLine($"{employees.Id} : {employees.Salary}");
}
    
    
}