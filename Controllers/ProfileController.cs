using Microsoft.AspNetCore.Mvc;

namespace Lingva.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
