
namespace OOPVehicleApp;
using System;
class Program
{
    static void Main(string[] args)
    {
        Vehicle v = new Car("BMW");

        v.start();

        Car c = (Car)v;
        c.Drive();
    }
}