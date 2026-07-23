// See https://aka.ms/new-console-template for more information

using HR;
using HR.Interfaces;
using HR.Services;
using HR.Repositories;

SalesManager manager = new SalesManager("Roshan",3000,7000,2000);

IAppraisable appraisable = manager;
appraisable.ConductAppraisal();

Console.WriteLine();

IBonusEligible bonusEligible = manager;
Console.WriteLine("Bonus: " + bonusEligible.CalculateBonus());

Console.WriteLine();


IInterviewPanel panel = manager;
panel.TakeInterview();

Console.WriteLine();


ITrainer trainer = manager;
trainer.Train();

Console.WriteLine();

Employee emp1=new SalesEmployee("Sanika",2000,5000);
Employee emp2=new SalesManager("Roshan",3000,7000,1000);

emp1.DoWork();
Console.WriteLine(emp1);
Console.WriteLine("Salary = " + emp1.ComputePay());

Console.WriteLine();

emp2.DoWork();
Console.WriteLine(emp2);
Console.WriteLine("Salary = " + emp2.ComputePay());



// Create dependency
// IEmployeeService service = new EmployeeService();

var service = new EmployeeService();

// Inject dependency
HRProcessor processor = new HRProcessor(service);

// // Create employees
// Employee emp1 = new SalesEmployee();
// Employee emp2 = new SalesManager();

// // Process employees
// processor.Process(emp1);
// processor.Process(emp2);



// Create Repository
IEmployeeRepository repository = new InMemoryEmployeeRepository();

// Inject Repository into Service
IEmployeeService service1 = new EmployeeService(repository);

// Inject Service into Processor
HRProcessor processor1 = new HRProcessor(service);

// // Create Employees
// Employee emp1 = new SalesEmployee(
//     "Rahul",
//     50000,
//     10000
// );

// Employee emp2 = new SalesManager(
//     "Priya",
//     80000,
//     15000,
//     10000
// );

// Add Employees to Repository
service.AddEmployee(emp1);
service.AddEmployee(emp2);

// Process Employees
processor.Process(emp1);
processor.Process(emp2);

// Display all Employees
Console.WriteLine("\nEmployee List:");

foreach (Employee emp in service1.GetEmployees())
{
    Console.WriteLine(emp);
}