using Microsoft.AspNetCore.Mvc;

namespace PhungDinhHung.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Play()
        {
            return View();
        }
    }
}
