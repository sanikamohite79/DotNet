namespace DependancyInjectionAPP;

public class Client
{
    private readonly IService _service;

    public Client(IService service)
    {
        _service = service;
    }

    public void Execute()
    {
        _service.DoWork();
    }
}