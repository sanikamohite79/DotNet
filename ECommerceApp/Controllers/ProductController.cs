using Microsoft.AspNetCore.Mvc;
using System;


public class ProductController : Controller
{
   public IActionResult Index()
   {
    return View();
   } 
}