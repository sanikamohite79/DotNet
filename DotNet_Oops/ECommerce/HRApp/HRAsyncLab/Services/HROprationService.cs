using HR.Models;

namespace HR.Services
{
    public class HROperationService
    {
        // Fetch all employees asynchronously
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            Console.WriteLine("Loading employees from database...");

            await Task.Delay(2000);

            return new List<Employee>
            {
                new Employee
                {
                    Id = 101,
                    Name = "Amit",
                    Department = "IT",
                    Salary = 50000
                },

                new Employee
                {
                    Id = 102,
                    Name = "Neha",
                    Department = "HR",
                    Salary = 40000
                },

                new Employee
                {
                    Id = 103,
                    Name = "Ravi",
                    Department = "Finance",
                    Salary = 60000
                }
            };
        }

        // Get one employee by Id
        public async Task<Employee?> GetEmployeeByIdAsync(int id)
        {
            List<Employee> employees = await GetEmployeesAsync();

            return employees.FirstOrDefault(e => e.Id == id);
        }

        // Calculate Bonus
        public async Task<double> CalculateBonusAsync(Employee employee)
        {
            Console.WriteLine($"\nCalculating bonus for {employee.Name}...");

            await Task.Delay(1000);

            return employee.Salary * 0.10;
        }

        // Save Employee
        public async Task SaveEmployeeAsync(Employee employee)
        {
            Console.WriteLine("\nSaving employee...");

            await Task.Delay(1500);

            Console.WriteLine($"Employee {employee.Name} saved successfully.");
        }
    }
}