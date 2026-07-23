

using System.Text.Json;
namespace Serialization;

public class RepositoryManager
{
    public void Serialize(List<Employee> employees,string fileName)
    {
        string json =JsonSerializer.Serialize(employees, new JsonSerializerOptions {  WriteIndented = true  });

        File.WriteAllText(fileName, json);

        Console.WriteLine("Data Saved!");
    }

    public List<Employee> Deserialize( string fileName)
    {
        string json = File.ReadAllText(fileName);

        return JsonSerializer.Deserialize<List<Employee>>(json);
    }
}