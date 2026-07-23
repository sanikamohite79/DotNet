using HR;

namespace HR.Services;

public class HRProcessor
{
    private readonly IEmployeeService _employeeService;

    // Constructor Injection
    public HRProcessor(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    public void Process(Employee employee)
    {
        float salary = _employeeService.GetSalary(employee);
        Console.WriteLine(employee);
        Console.WriteLine("Final Salary: " + salary);
    }
}