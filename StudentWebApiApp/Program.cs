
using StudentWebApiApp;
using StudentService;
using System.Collections.Generic;

namespace WebApp
{
    class Program
    {

public static async Task Main(string[] args)
{
    Console.WriteLine(".............Student Info........");
    StudentServices service = new StudentServices();
     List<Student> students =await service.GetStudentAsync();
     Console.WriteLine("Print Students");
     Console.WriteLine(students);
     Console.WriteLine();

     foreach(Student s in students)
     {
        Console.WriteLine(s);
     }

     Console.WriteLine("\n serchong student with ID 103:...");

     Student? stud =await service.GetStudentByIdAsync(103);
     if(stud != null)
     {
        Console.WriteLine("Found Student");
        Console.WriteLine(stud);

        await service.SaveStudentAsync(stud);

     }
    else
        {
             Console.WriteLine("Student Not Found");
        }         

    }
}
}