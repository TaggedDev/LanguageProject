using Lingva.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lingva.Controllers
{
    public class LessonCreateController : Controller
    {
        public IActionResult Test()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChooseLanguage(ChooseLanguage model)
        {
            // Когда пользователь нажимает на кнопку, он попадает сюда. В model содержится данные, 
            // взятые в radiobutton'ах
            return View(model);
        }

        public IActionResult ChooseLanguage()
        {

            return View();
        }

        public IActionResult LessonTemplate()   
        {
            ChooseLanguage choose = new ChooseLanguage();
            return View(choose);
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
