
namespace StudentResultSystem.Models
{
    public class Student
    {
        public int RollNo { get; set; }

        public string Name { get; set; }= "";

        public int English { get; set; }

        public int Maths { get; set; }

        public int Science { get; set; }

        public int Total => English + Maths + Science;

        public double Percentage => Total / 3.0;

        public string Result => Percentage >= 35 ? "Pass" : "Fail";
    }
}