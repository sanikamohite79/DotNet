using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ECommercePortal.Models;

namespace ECommercePortal.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {

        string title = "Transflower";
        ViewBag.CompanyName = title;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Welcome()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
