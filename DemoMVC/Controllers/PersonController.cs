using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models; 
namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strResult = "Hello " + ps.PersonID + "-" + ps.PersonName;
            ViewBag.thongBao = strResult;
            return View();
        }
    }
}