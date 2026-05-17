using Microsoft.AspNetCore.Mvc;
namespace MVCPROJECT.Controllers
{
    public class ProductControllers : Controller
    {
        public IActionResult Index()
        {
            return View();  
        }
    }
}
