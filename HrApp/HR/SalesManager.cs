namespace HR;
 public class SalesManager:SalesEmployee
 {
     double Bouns;

    public SalesManager(string name,double salary,double incentive,double bouns)
    :base(name,salary,incentive)
    {
        Bouns=bouns;

    }

    public override double ComputePay()
    {
        return base.ComputePay()+Bouns;
    }
    public override void DoWork()
    {
        Console.WriteLine("manages the sales team:"+Name);
    }
 }