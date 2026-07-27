using System;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

List<Employee> employees = new();

app.MapGet("/employees", () => employees);

app.Run();