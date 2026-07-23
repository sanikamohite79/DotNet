using System;
namespace OOPVehicleApp;
public class Car:Vehicle ,IDrive
{
    public Car(string name):base(name)
     { 

     }  
        public override void start()
        {
            Console.WriteLine(Name + "  is Started");
        }
        public void Drive()
        {
            Console.WriteLine(Name  + "  is Driving");
        }
    
}