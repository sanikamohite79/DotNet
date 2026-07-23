using System;

namespace InterfaceApp;

public  class Cat : IAnimal
{
    public  void MakeSound()
    {
        Console.WriteLine("Cat says: Meow Meow");
    }
}