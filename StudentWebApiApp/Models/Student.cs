
namespace StudentWebApiApp;

public class Student
{
    public int Id{get; set;}
    public string Name{get; set;}="";
    public string Department{get; set;}="";


      public override string ToString()
        {
            return $"{Id} | {Name} | {Department}";
        }
}
