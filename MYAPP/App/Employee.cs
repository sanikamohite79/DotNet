namespace EmployeeApp; //package declaration-store multiple class

public class Employee{     //class declaration             

    public int hra;           //variable 
    public int salary;
    public int totalSalary;


    public Employee(){           //cunstactor
        hra =20000;
        salary=30000;

    }
    

    public void display(){             //display value
        totalSalary=hra+salary;
        Console.WriteLine("totalSalary "+totalSalary);
    }
}