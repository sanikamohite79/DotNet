// See https://aka.ms/new-console-template for more information

using HR;

Employee emp1=new SalesEmployee("Sanika",2000,5000);
Employee emp2=new SalesManager("Roshan",3000,7000,1000);

emp1.DoWork();
Console.WriteLine(emp1);
Console.WriteLine("Salary = " + emp1.ComputePay());

Console.WriteLine();

emp2.DoWork();
Console.WriteLine(emp2);
Console.WriteLine("Salary = " + emp2.ComputePay());