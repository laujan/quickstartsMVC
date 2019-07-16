using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvcQuickStartTabs.Controllers
{
    [Route("red")]
    public class RedController : Controller
    {
        [Route("")]
        public IActionResult Red()
        {
            ViewBag.Message = "Success!";
            return View();
        }
    }
}