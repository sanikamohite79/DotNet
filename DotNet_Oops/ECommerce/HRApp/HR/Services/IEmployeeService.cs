using HR;

namespace HR.Services;

public interface IEmployeeService
{
    float GetSalary(Employee employee);
    void PerformDuties(Employee employee);
    void AddEmployee(Employee employee);
    List<Employee> GetEmployees();
}