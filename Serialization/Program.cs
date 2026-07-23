using Serialization;

List<Employee> employees = new List<Employee>()
{
    new Employee
    {
        Id = 101,
        Name = "Sanika",
        Salary = 50000
    },

    new Employee
    {
        Id = 102,
        Name = "Rosham",
        Salary = 60000
    }
};

RepositoryManager repo = new RepositoryManager();

repo.Serialize( employees, "employees.json");

Console.WriteLine("\nReading Data...\n");

List<Employee> result = repo.Deserialize("employees.json");

foreach(Employee emp in result)
{
    Console.WriteLine( $"{emp.Id} {emp.Name} {emp.Salary}");
}