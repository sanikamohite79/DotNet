namespace OOPVehicleApp;

public  abstract class Vehicle
{
    public string Name;

    public Vehicle(string name)
    {
        Name=name;
    }

    public abstract void start();
}