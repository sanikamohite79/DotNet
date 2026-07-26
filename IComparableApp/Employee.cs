

using System;

public class Employee : IComparable<Employee>
{
    public string Name { get; set; }
    public int Salary { get; set; }

    public int CompareTo(Employee? other)
    {
         if (other == null)
            return 1;
            
        return Salary.CompareTo(other.Salary);
    }
}