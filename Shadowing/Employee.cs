namespace Shadowing;
class Employee
{
    protected double basic_sal = 20000;

    public virtual double CalculateSalary()
    {
        return basic_sal;
    }
}
