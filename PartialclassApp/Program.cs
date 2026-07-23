
using PartialclassApp;
class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount
        {
            AccountNumber = "ACC123",
            CustomerName = "Sanika Mohite",
            Balance = 1000
        };

        account.Deposit(500);          // Works seamlessly
        account.Withdraw(200);         // Works seamlessly
        account.ApplyInterest(0.05m);  // Works seamlessly
    }
}