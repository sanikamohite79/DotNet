
namespace InterfaceApp;
public class SavingAccount:IAccount
{
    public double balance;

    public SavingAccount:IAccount
    {
        public double balance;
        Public SavingAccount(double balance)
        {
            this.balance=balance;
        }

        public void Deposit(double Amount)
        {
            balance = balance+Amount;
            Console.WriteLine($"Deposit:{Amount}");
        }

        public void withdraw(double Amount)
        {
            if(amount <= balance){
                balance = balance -Amount;
                Console.WriteLine($"Withdraw:{Amount}");
            }
            else
            {
                Console.WriteLine("Insifficient balance")
            }
        }
        public void DisplayBalance()
        {
            Console.WriteLine($"Saving Account Balance:{balance}");
        }
    } 
}