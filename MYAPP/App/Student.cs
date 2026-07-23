namespace StudentApp; //package declaration-store multiple class

public class Student{     //class declaration             

    public int hra;           //variable 
    public int salary;
    public int totalSalary;


    public Student(){           //cunstactor
        hra =20000;
        salary=30000;

    }
    public void show(){             //display value
        totalSalary=hra+salary;
        Console.WriteLine("totalSalary  "+totalSalary);
    }
}