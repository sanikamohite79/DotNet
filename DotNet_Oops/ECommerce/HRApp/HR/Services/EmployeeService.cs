using HR;
using HR.Repositories;

namespace HR.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repository;

    // Repository injected
    public EmployeeService(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public float GetSalary(Employee employee)
    {
        employee.DoWork();
        return (float)employee.ComputePay();
    }

    public void PerformDuties(Employee employee)
    {
        employee.DoWork();
        Console.WriteLine("Employee duties completed.");
    }

    public void AddEmployee(Employee employee)
    {
        _repository.Add(employee);
    }

    public List<Employee> GetEmployees()
    {
        return _repository.GetAll();
    }
}