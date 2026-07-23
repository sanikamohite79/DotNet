using HR;

namespace HR.Repositories;

public interface IEmployeeRepository
{
    void Add(Employee employee);
    void Update(Employee employee);
    Employee GetById(int id);
    List<Employee> GetAll();
}