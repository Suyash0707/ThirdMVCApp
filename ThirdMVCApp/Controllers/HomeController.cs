using Microsoft.AspNetCore.Mvc;
using ThirdMVCApp.Models;

namespace ThirdMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            SecondMvcappDbContext obj = new SecondMvcappDbContext();
            var students = obj.Students;

            return View(students);
        }
       public IActionResult Create()
        {
            return View();
        }
    }
}
