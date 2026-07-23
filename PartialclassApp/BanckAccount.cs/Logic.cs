namespace PartialclassApp;

public partial class BankAccount
{
    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"{CustomerName} deposited {amount}. New Balance: {Balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"{CustomerName} withdrew {amount}. New Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }

    public void ApplyInterest(decimal rate)
    {
        Balance += Balance * rate;
        Console.WriteLine($"Interest applied to {CustomerName}'s account. New Balance: {Balance}");
    }
}