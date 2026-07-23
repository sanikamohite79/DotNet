using HR;

namespace HR.Repositories;

public class InMemoryEmployeeRepository : IEmployeeRepository
{
    private readonly List<Employee> _employees = new();

    public void Add(Employee employee)
    {
        _employees.Add(employee);
        Console.WriteLine("Employee added to repository.");
    }

    public void Update(Employee employee)
    {
        var emp = GetById(employee.Id);
        if (emp != null)
        {
            _employees.Remove(emp);
            _employees.Add(employee);
            Console.WriteLine("Employee updated.");
        }
    }

    public Employee GetById(int id)
    {
        return _employees.FirstOrDefault(e => e.Id == id);
    }

    public List<Employee> GetAll()
    {
        return _employees;
    }
}