namespace Shadowing;
class SalesEmployee : Employee
{
    double sales = 100;
    double comm = 50;

    public new double CalculateSalary()
    {
        return basic_sal + (sales * comm);
    }
}