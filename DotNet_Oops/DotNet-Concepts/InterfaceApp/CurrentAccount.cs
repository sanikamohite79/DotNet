
namespace InterfaceApp;
public class CurrentAccount:IAccount
{
    public double balance;

    public CurrentAccount(double balance)
    {
        this.balance= balance;
    }
    public void Deposit(double Amount)
    {
        balance= balance + Amount;
        Console.WriteLine($"Deposit:{Anount}");
    }
    public void withdraw(double Amount)
    {
         if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
          public void DisplayBalance()
    {
        Console.WriteLine($"Saving Account Balance: {balance}");
    }
    }
}