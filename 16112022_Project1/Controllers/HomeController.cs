using Microsoft.AspNetCore.Mvc;

namespace _16112022_Project1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
