using StudentWebApiApp;

namespace StudentService
{
    public class StudentServices
    {
        private List<Student> students = new List<Student>
        {
            new Student { Id = 101, Name = "Sanika", Department = "IT" },
            new Student { Id = 102, Name = "Rahul", Department = "Computer" },
            new Student { Id = 103, Name = "Priya", Department = "Electronics" }
        };

        // Get All Students
        public async Task<List<Student>> GetStudentAsync()
        {
            await Task.Delay(2000);
            return students;
        }

        // Get Student By Id
        public async Task<Student?> GetStudentByIdAsync(int id)
        {
            await Task.Delay(1000);

            return students.FirstOrDefault(s => s.Id == id);
        }

        // Save Student
        public async Task SaveStudentAsync(Student student)
        {
            await Task.Delay(1000);

            Console.WriteLine("Saving Student...");
            Console.WriteLine(student);
        }
    }
}