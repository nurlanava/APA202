using _26_DynamicPropertiesViewModel.Models;
using _26_DynamicPropertiesViewModel.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _26_DynamicPropertiesViewModel.Controllers
{
    public class HomeController : Controller
    {

        List<Student> _students = new List<Student>
        {
            new Student{Id=1, Name="Qumral", Surname="Tehmez"},
            new Student{Id=2, Name="Gunay", Surname="Eliyeva"},
            new Student{Id=3, Name="Arzu", Surname="Babayeva"}
        };

        List<Teacher> _teachers = new List<Teacher>
        {
            new Teacher{Id=2, Name="Ali", Salary=3000},
            new Teacher{Id=1, Name="Ahmed", Salary=2400}  
        };

        public IActionResult Index()
        {
            //ViewBag.Students = _students;
            //ViewData["Students"]=_students;
            //TempData["Name"] = "Ali";

            HomeVM homeVM = new()
            {
                Teachers=_teachers,
                Students=_students
            };

            return View(homeVM);
        }

     
        public IActionResult Details()
        {
            return View();
        }


        [Route("korporativ-satislar")]
        public IActionResult CorporativeSales()
        {
            return View();
        }
    }
}
