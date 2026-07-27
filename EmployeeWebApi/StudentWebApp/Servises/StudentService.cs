

namespace Services;
using StudentWebApp;
using System.Collections.Generic;

public class StudentService
{
    public static List<Student> GetAll()
    {
        List<Student> students= new List <Student>();
        students.Add(new Student{ Id=1 , Name="Sanika" , Age=20 ,Course="IT" });
        students.Add(new Student{  Id=2 , Name="Roshan" , Age=20 ,Course="cse"  });
        return students;
    }

    public static string Insert()
    {
        Console.WriteLine("New student inserttion Process.");
        return "student inserted successfully";
    }
}