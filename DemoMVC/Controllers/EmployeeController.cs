using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee employee)
        {
            string strResult = "Hello " + employee.EmployeeId + "-" + employee.Age;
            ViewBag.thongBao = strResult;
            return View();
        }
    }
}
