using Microsoft.AspNetCore.Mvc;

namespace MVCdemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contactus()
        {
            return View();
        }
    }
}
