using Microsoft.AspNetCore.Mvc;

namespace Lingva.Controllers
{
    public class IntroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
