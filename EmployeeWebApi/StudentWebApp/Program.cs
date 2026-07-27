
using StudentWebApp;
using Services;



var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
 app.MapGet("/student" , () => {
     return student;
     });

 app.MapPost("/student ", (Student student) => {
    student.Add(student);
    return"Student Add Successfully";
  });

  app.MapPut("/student/{id}",(int id, Student updatedStudent) => {
    var student=student.FirstOrDefault(s => s.Id == id);

    if(student==null)
    return Result.NotFound("Student Not Found");

     student.Name = updatedStudent.Name;
    student.Age = updatedStudent.Age;
    student.Course = updatedStudent.Course;

    return Results.Ok("Student Updated Successfully");

  });


app.MapDelete("/students/{id}", (int id) =>
{
    var student = student.FirstOrDefault(s => s.Id == id);

    if (student == null)
        return Results.NotFound("Student Not Found");

    students.Remove(student);

    return Results.Ok("Student Deleted Successfully");
});



app.Run();


