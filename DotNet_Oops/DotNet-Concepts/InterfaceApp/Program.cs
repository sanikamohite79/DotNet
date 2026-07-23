
using InterfaceApp;

class Program
{
    static void Main()
    {
        IAccount saving = new SavingAccount(10000);
        saving.Deposit(2000);
        saving.Withdraw(1500);
        saving.DisplayBalance();

        Console.WriteLine();

        IAccount current = new CurrentAccount(5000);
        current.Deposit(1000);
        current.Withdraw(3000);
        current.DisplayBalance();
    }
}
