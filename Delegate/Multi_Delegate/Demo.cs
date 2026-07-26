
using System;

public delegate void StrDelegate(string str);

class Demo
{
    public void UppercaseStr(string str)
    {
        Console.WriteLine(str.ToUpper());
    }

    public void LowercaseStr(string str)
    {
        Console.WriteLine(str.ToLower());
    }
}
