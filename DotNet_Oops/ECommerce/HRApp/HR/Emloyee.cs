namespace HR;
public abstract class Employee
{
    public string Name;
    public double Salary;
    public int Id { get; set; }

    public Employee(string name, double salary)

    {
        Name=name;
        Salary=salary;

    }

    public virtual double ComputePay()
    {
        return Salary;

    }

    public abstract void DoWork();

    public override string ToString()
    {
        return Name;

    }
}