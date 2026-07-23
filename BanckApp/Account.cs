namespace BanckApp;

class Account
{
    public decimal Balance { get; set; }

    // Virtual method can be overridden
    public virtual void ProcessTransaction(decimal amount)
    {
        Balance=0;
        Balance = Balance+ amount;
        Console.WriteLine($"Generic account: Deposited {amount}. Balance: {Balance}");
    }
}