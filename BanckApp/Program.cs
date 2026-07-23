
using System;
namespace BanckApp;

public class Program
{
    public static void Main(string [] args)
    {
        Account acc1 = new SavingAccount();
        Account acc2 = new CurrentAccount();

acc1.ProcessTransaction(1000); // Applies interest
acc2.ProcessTransaction(1000); // Just adds amount
    }
}