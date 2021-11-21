using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lingva.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Russian()
        {
            return View();
        }
    }
}
