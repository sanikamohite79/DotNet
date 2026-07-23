var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

app.MapGet("/api/machinedata", () =>
{
    return new[]
    {
        new { MachineId = 1, Status = "Running", Temperature = 75.5 },
        new { MachineId = 2, Status = "Stopped", Temperature = 0.0 },
        new { MachineId = 3, Status = "Running", Temperature = 80.0 }
    };
});

app.MapGet("/api/factoryenvironment", () =>
{
    return new[]
    {
        new { FactoryId = 1, Environment = "Normal", Humidity = 50.0, Pressure = 1013.25 },
        new { FactoryId = 2, Environment = "Critical", Humidity = 80.0, Pressure = 980.0 },
        new { FactoryId = 3, Environment = "Normal", Humidity = 45.0, Pressure = 1015.0 }
    };
});

app.MapRazorPages();

app.Run();