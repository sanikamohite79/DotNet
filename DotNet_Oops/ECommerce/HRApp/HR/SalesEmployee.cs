namespace HR;
using HR.Interfaces;

public class SalesEmployee:Employee , IAppraisable
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

          public virtual  void ConductAppraisal()
    {
        Console.WriteLine("Sales Employee appraisal completed.");
    }
}