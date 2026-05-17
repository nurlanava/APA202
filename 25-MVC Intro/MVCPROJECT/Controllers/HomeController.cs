using Microsoft.AspNetCore.Mvc;

namespace MVCPROJECT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content("APA202");
            //var student = new JsonResult(new { id = 1, name = "ALi", surname = "Quliyev" });
            return View();  
        }
        public IActionResult Detail(int? id)
        {
            if (id is null || id < 1)
            {
                return RedirectToAction(nameof(Error));
            }
            return RedirectToAction(nameof(Index),"Product");
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
