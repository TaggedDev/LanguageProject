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

        [HttpPost("ChooseLanguage")]
        public IActionResult ChooseLanguage(Lesson model)
        {
            // Когда пользователь нажимает на кнопку, он попадает сюда. В model содержится данные, 
            // взятые в radiobutton'ах
            return RedirectToAction("ChooseTheme", model);
        }

        public IActionResult ChooseLanguage()
        {
            return View();
        }

        [HttpPost("ChooseTheme")]
        public IActionResult ChooseThemePost(Lesson model)
        {
            // Вызывается при отправке формы
            return RedirectToAction("ChooseTask", model);
        }

        public IActionResult ChooseTheme(Lesson model)
        {
            // Вызывается из другого Action
            return View(model);
        }

        [HttpPost("ChooseTask")]
        public IActionResult ChooseTaskPost(Lesson model)
        {
            return RedirectToAction("ChooseTaskType", model);
        }

        public IActionResult ChooseTask(Lesson model)
        {
            return View(model);
        }
        
        [HttpPost("ChooseTask")]
        public IActionResult ChooseTaskTypePost(Lesson model)
        {
            return View();
        }

        public IActionResult ChooseTaskType(Lesson model)
        {
            return RedirectToAction("ChooseTaskType", model);
        }

        public IActionResult ChooseNeedTheme()
        {
            return View();
        }
    }
}
