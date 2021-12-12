using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lingva.Controllers
{
    public class LessonCreateController : Controller
    {
        public IActionResult ChooseLanguage()
        {
            return View();
        }

        public IActionResult ChooseTheme()
        {
            return View();
        }

        public IActionResult ChooseTaskType()
        {
            return View();
        }

        public IActionResult ChooseTask()
        {
            return View();
        }
        public IActionResult ChooseNeedTheme()
        {
            return View();
        }
    }
}
