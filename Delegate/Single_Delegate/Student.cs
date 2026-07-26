
using System;
 
 delegate void MyDelegate(string name);//Declare Delegate

 class Student
 {
    public void Greet (string name)// Create Method
    {
        Console.WriteLine("Hello  " + name);
    }
 }
