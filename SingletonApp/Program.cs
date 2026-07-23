using SingletonApp;
class Program
{
    static void Main()
    {
        BankManager manager1 = BankManager.Instance;
        BankManager manager2 = BankManager.Instance;

        manager1.ApproveLoan(50000);

        // Are both references pointing to the same instance?
        Console.WriteLine(Object.ReferenceEquals(manager1, manager2)); // True
    }
}