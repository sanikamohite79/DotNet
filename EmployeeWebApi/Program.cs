using WebApiDemo;
using Entities;
using Entitie;
using Service;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/employee", () => 
{
    return EmployeeService.GetAll();
});
app.MapGet("/api/empoyee", () =>
{
    return EmployeeService.Insert();
});


app.MapGet("/api/customers", () =>{return  "tanvi, Roshan, Sanika";});
app.MapGet("/api/cart", () =>{return  "laptop-2, samsung-6, earbuds-8";});
app.MapGet("/api/orders", () =>{return  "ord123, ord432, ord987";});
app.MapGet("/api/products" , () => {return ProductServices.GetAll();});
app.MapPost("/api/products" , () => {return ProductServices.Insert();});


app.Run();
