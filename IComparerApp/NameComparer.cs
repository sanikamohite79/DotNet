
using System.Collections.Generic;

public class NameComparer : IComparer<Employee>//Allways create saprate class to compare
{
    public int Compare(Employee? x, Employee? y)
    {
        return x!.Name.CompareTo(y!.Name);
    }
}