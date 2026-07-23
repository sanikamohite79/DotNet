using System.Text.Json;

using SerializationMethod;

BankAccount account = new BankAccount
{
    AccountNumber = 1001,
    AccountHolderName = "Sanika",
    Balance = 50000
};

string json = JsonSerializer.Serialize(account);//Converting an object into a storable format (JSON).

File.WriteAllText("account.json", json);

Console.WriteLine("Serialization Successful! ");
Console.WriteLine(json);


string jsonFromFile = File.ReadAllText("account.json");

BankAccount? loadedAccount =
    JsonSerializer.Deserialize<BankAccount>(jsonFromFile);

Console.WriteLine("\nDeserialized Object:");
Console.WriteLine($"Account Number: {loadedAccount?.AccountNumber},Account Holder: {loadedAccount?.AccountHolderName},Balance: {loadedAccount?.Balance}");