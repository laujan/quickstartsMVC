using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvcQuickStartTabs.Controllers
{
    [Route("privacy")]
    public class PrivacyController : Controller
    {
        [Route("")]
        public IActionResult Privacy()
        {
            ViewBag.Message = "Add your privacy statement here...";
            return View();
        }
    }
}

