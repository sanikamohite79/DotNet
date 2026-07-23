using Microsoft.AspNetCore.Mvc;

namespace Transflower.Controllers
{
    public class HomeController : Controller
    {
         public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    
        public IActionResult Courses()
        {
            ViewBag.Course1 = "C Programming";
            ViewBag.Duration1 = "2 Months";
            ViewBag.Fees1 = "₹10,000";

            ViewBag.Course2 = "Java";
            ViewBag.Duration2 = "4 Months";
            ViewBag.Fees2 = "₹15,000";

            ViewBag.Course3 = "C# and .NET";
            ViewBag.Duration3 = "3 Months";
            ViewBag.Fees3 = "₹14,000";

            return View();
        }
    
        public IActionResult Contact()
        {
            
            return View();
        }
    }
}