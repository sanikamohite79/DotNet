
using System.Text.Json;

using Demo;

    Employee emp = new Employee();
    
     emp.Id= 101;
      emp.Name="sanika";
    
     string json = JsonSerializer.Serialize(emp);
     File.WriteAllText("emp.json",json);
     Console.WriteLine("Serialization Successful!");
     Console.WriteLine(json);

string jsonFromFile = File.ReadAllText("emp.json");

emp = JsonSerializer.Deserialize<Employee>(jsonFromFile);//This converts the JSON string into an Employee object.
Console.WriteLine(emp.Id);
Console.WriteLine(emp.Name);

