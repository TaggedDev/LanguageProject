using Microsoft.AspNetCore.Mvc;

namespace Lingva.Controllers
{
    public class LearnController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
