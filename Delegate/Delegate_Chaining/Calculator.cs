

using System;
public delegate void CalDelegate(int x , int y);

class Calculator
{
    public void Add(int x ,int y)
    {
        Console.WriteLine($"Addition: {x+y}");
    }
    public void Sub(int x,int y)
    {
        Console.WriteLine($"Subtraction = {x-y}");
    }
    public void Multiply(int x , int y)
    {
        Console.WriteLine($"Multiplication = {x*y}");
    }
}