using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mvcQuickStartTabs.Controllers
{
    [Route("gray")]
    public class GrayController : Controller
    {
        [Route("")]
        public IActionResult Gray()
        {
            ViewBag.Message = "Success!";
            return View();
        }
    }
}