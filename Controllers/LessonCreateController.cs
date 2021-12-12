using Lingva.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lingva.Controllers
{
    public class LessonCreateController : Controller
    {
        
        public string CheckRadio(FormCollection form)
        {
            return $"Returned value is {form["Language"]}";
        }

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
