using Microsoft.AspNetCore.Mvc;

public class SalaryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

  [HttpPost]
public IActionResult Index(SalaryModel model)
{
    if (ModelState.IsValid)
    {
        return View(model); // Trả về model sau khi kiểm tra hợp lệ
    }
    return View();
}

}
