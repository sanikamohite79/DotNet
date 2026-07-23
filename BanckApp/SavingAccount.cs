namespace BanckApp;
class SavingAccount : Account
{
    public decimal InterestRate { get; set; } = 0.05m;

    public override void ProcessTransaction(decimal amount)
    {
        Balance += amount;
        Balance += Balance * InterestRate; // Apply interest
        Console.WriteLine($"Saving Account: Deposited {amount} + interest(0.05*100).= Balance: {Balance}");
    }
}