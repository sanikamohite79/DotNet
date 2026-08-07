
using Microsoft.AspNetCore.Mvc;

using ECommerceApp.Models;
namespace ECommerceApp.Controllers;

public class AuthController : Controller
{


    [HttpGet]
    public IActionResult Login()
    {
        Credential credential =new Credential();
        credential.UserName ="";
        credential.Password="";

        return View (credential);
    }

    [HttpGet]
    public IActionResult Register()
    {
         Customer customer =new Customer();
         customer.Name="";
         customer.Email="";
         customer.Phone="";
         customer.Id=0;

        return View();

    }

    [HttpPost]
    public IActionResult Register(Customer customer)
    {
        Console.WriteLine($"New user registered: {customer.Email},{customer.Phone},{customer.Name}");
        return RedirectToAction("Login");
    }
}