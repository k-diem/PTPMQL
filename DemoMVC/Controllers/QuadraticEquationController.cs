using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student std)
        {
            string str = "Hello " + std.StudentID + "-" + std.FullName;
            ViewBag.thongBao = str;

            QuadraticEquationModel equation = new QuadraticEquationModel
            {
                A = 1, 
                B = 2, 
                C = 1  
            };
            equation.Solve();
            ViewBag.Root1 = equation.Root1;
            ViewBag.Root2 = equation.Root2;

            return View();
        }
    }
}
