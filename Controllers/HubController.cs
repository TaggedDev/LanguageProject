using Microsoft.AspNetCore.Mvc;

namespace Lingva.Controllers
{
    public class HubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
