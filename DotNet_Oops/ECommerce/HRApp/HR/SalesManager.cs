namespace HR;

using HR.Interfaces;

 public class SalesManager:SalesEmployee , IManagerBenefits,
                            IInterviewPanel,
                            ITrainer
         
 {
    private double Bouns;

    public SalesManager(string name,double salary,double incentive,double bouns)
    :base(name,salary,incentive)
    {
        Bouns=bouns;

    }

    
    public float CalculateBonus()
    {
        return (float)Bouns;
    }

    public override void ConductAppraisal()
    {
        Console.WriteLine("Manager appraisal completed.");
    }

    public void ApproveLeave()
    {
        Console.WriteLine("Leave approved by Sales Manager.");
    }

    public void TakeInterview()
    {
        Console.WriteLine("Sales Manager conducting interview.");
    }

    public void Train()
    {
        Console.WriteLine("Sales Manager training sales team.");
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