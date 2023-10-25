using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class QuadraticEquationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double a, double b, double c)
        {
            // Thực hiện giải phương trình bậc 2 ở đây
            double discriminant = b * b - 4 * a * c;
            double root1, root2;

            if (discriminant > 0)
            {
                root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
            else if (discriminant == 0)
            {
                root1 = root2 = -b / (2 * a);
            }
            else
            {
                root1 = root2 = double.NaN; // Không có nghiệm thực
            }

            ViewBag.Root1 = root1;
            ViewBag.Root2 = root2;

            return View();
        }
    }
}
