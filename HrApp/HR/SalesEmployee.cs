namespace HR;
public class SalesEmployee:Employee
{
    public double Incentive;

     public SalesEmployee(string name, double salary, double incentive)
        : base(name, salary)

        {
            Incentive=incentive;
        }

        public override double ComputePay()
        {
            return Salary+Incentive;

        }

        public override void DoWork()
        {
            Console.WriteLine("sells Produt:" +Name);
        }
} 