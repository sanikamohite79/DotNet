
namespace DependancyInjectionAPP;
using System;
public class Program
{
    public static void Main (string [] args)
    {
        IService service = new Service();

Client client = new Client(service);

client.Execute();
    }
}