namespace BanckApp;

class CurrentAccount : Account
{
    public override void ProcessTransaction(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Current Account: Deposited {amount}. Balance: {Balance}");
    }
}