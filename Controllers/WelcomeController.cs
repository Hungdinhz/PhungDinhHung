using Microsoft.AspNetCore.Mvc;

namespace PhungDinhHung.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
