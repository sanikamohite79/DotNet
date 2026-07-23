
namespace BankApp;

public class Bank
{
    public int Interest;
    public int Saving;

    public Bank(int interest, int saving)
    {
        Interest = interest;
        Saving = saving;
    }

    public void Display()
    {
        int total = Interest + Saving;

        Console.WriteLine("\nInterest Amount: " + Interest);
        Console.WriteLine("Saving Amount: " + Saving);
        Console.WriteLine("Total Amount: " + total);
    }
}