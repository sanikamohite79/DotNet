using System;

namespace InterfaceApp;

public  class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Dog says: Bark Bark");
    }
}