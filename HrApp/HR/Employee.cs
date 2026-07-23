namespace HR;

public abstract class Employee
{
    public string Name;
    public double Salary;


public Employee(string name,double salary)
{
    this.Name=name;
    this.Salary=salary;
}

public  virtual double ComputePay()
{
    return Salary;
}

public override string ToString()
{
    return Name;
}

public abstract void DoWork();

}