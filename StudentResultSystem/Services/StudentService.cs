using StudentResultSystem.Models;

namespace StudentResultSystem.Services
{
    public class StudentService
    {
        private static List<Student> students = new();

        public List<Student> GetAll()
        {
            return students;
        }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public Student? Search(int rollNo)
        {
            return students.FirstOrDefault(s => s.RollNo == rollNo);
        }

        public Student? Topper()
        {
            return students
                    .OrderByDescending(s => s.Total)
                    .FirstOrDefault();
        }

        public List<Student> SortByMarks()
        {
            return students
                    .OrderByDescending(s => s.Total)
                    .ToList();
        }
    }
}