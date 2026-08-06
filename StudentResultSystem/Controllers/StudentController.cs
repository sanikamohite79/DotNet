using Microsoft.AspNetCore.Mvc;
using StudentResultSystem.Models;
using StudentResultSystem.Services;

namespace StudentResultSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService service;

        public StudentController(StudentService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View(service.GetAll());
        }

        // Add Student
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            service.Add(student);
            return RedirectToAction("Index");
        }

        // Search Page
        public IActionResult Search()
        {
            return View();
        }

        // Search Result
        [HttpPost]
        public IActionResult Search(int rollNo)
        {
            Student? student = service.Search(rollNo);

            if (student == null)
            {
                ViewBag.Message = "Student Not Found";
            }

            return View(student);
        }

        // Topper
        public IActionResult Topper()
        {
            Student? topper = service.Topper();

            return View(topper);
        }

        // Sorted List
        public IActionResult Sorted()
        {
            return View(service.SortByMarks());
        }
    }
}