using HR.Models;
using HR.Services;

namespace HRAsyncLab
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("========== HR SYSTEM ==========\n");

            HROperationService service = new HROperationService();

            // Fetch Employees
            List<Employee> employees = await service.GetEmployeesAsync();

            Console.WriteLine("\nEmployee List");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            // Get Employee by Id
            Console.WriteLine("\nSearching Employee with ID 104...\n");

            Employee? emp = await service.GetEmployeeByIdAsync(104);

            if (emp != null)
            {
                Console.WriteLine("Employee Found");
                Console.WriteLine(emp);

                // Calculate Bonus
                double bonus = await service.CalculateBonusAsync(emp);

                Console.WriteLine($"Bonus = {bonus}");

                // Save Employee
                await service.SaveEmployeeAsync(emp);
            }
            else
            {
                Console.WriteLine("Employee Not Found");
            }

            Console.WriteLine("\nHR System Completed.");
        }
    }
}