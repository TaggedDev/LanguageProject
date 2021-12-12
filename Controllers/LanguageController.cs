using Lingva.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lingva.Controllers
{
    public class LanguageController : Controller
    {
        
        public IActionResult English()
        {
            Lesson lesson = new Lesson()
            {
                LessonID = 1
            };               
            return View(lesson);
        }

        public IActionResult Russian()
        {
            Lesson lesson = new Lesson()
            {
                LessonID = 1
            };
            return View(lesson);
        }

        public IActionResult Deutch()
        {
            Lesson lesson = new Lesson()
            {
                LessonID = 1
            };
            return View(lesson);
        }
    }
}
