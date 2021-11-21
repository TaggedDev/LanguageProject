using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static web4.SeedData;

namespace web4.Controllers
{
    [Route("test")]
    public class TestController : Controller 
    {
        [Authorize(Roles = RoleNames.Administrator)]
        [Route("rest")]
        public IActionResult GetAdm() => Ok("Admin only page");

        [Route("work")]
        [Authorize(Roles = RoleNames.Moderator)]
        public IActionResult GetMod() => Ok("Moderator only page");
    }
}
