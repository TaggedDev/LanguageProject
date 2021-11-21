using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web4.Data;

namespace Lingva.Controllers
{
    public class TestAdminController : Controller
    {
        ApplicationDbContext _context;
        public TestAdminController(ApplicationDbContext context) 
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }
    }
}
