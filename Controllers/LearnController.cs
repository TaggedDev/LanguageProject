using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lingva.Controllers
{
    public class LearnController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
