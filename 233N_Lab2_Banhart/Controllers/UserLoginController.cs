using Microsoft.AspNetCore.Mvc;

namespace _233N_Lab2_Banhart.Controllers
{
    public class UserLoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
