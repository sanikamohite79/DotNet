namespace SingletonApp;
public sealed class BankManager
{
    // 3. Holds the one and only instance of BankManager
    private static BankManager? _instance = null;

    // 1. Private constructor - ensures no one else can create a manager
    private BankManager()
    {
        // Initialize resources, e.g., bank policies
    }

    // 4. Public accessor to get the single BankManager
    public static BankManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new BankManager();
            }
            return _instance;
        }
    }

    // Example behavior
    public void ApproveLoan(decimal amount)
    {
        Console.WriteLine($"Bank Manager approved a loan of {amount}.");
    }
}