using Microsoft.AspNetCore.Mvc;

namespace _233N_Lab2_Banhart.Controllers
{
    public class MyClassesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserLogin()
        {
            return View(); 
        }
    }
}
