using System;

namespace InterfaceApp;

class Program
{
    static void Main(string[] args)
    {
        IAnimal animal = new Dog();
        animal.MakeSound();

        
        IAnimal cat = new Cat();
        cat.MakeSound();
    }
}