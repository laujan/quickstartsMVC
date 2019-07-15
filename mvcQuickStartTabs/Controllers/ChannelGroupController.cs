using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcQuickStartTabs.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvcQuickStartTabs.Controllers
{
    [Route("channelgroup")]
    public class ChannelGroupController : Controller
    {
        [Route("")]
        public IActionResult ChannelGroup()
        {
            ChannelGroup color = new ChannelGroup();
            ViewBag.Gray = ($"{color.GetColor()} gray!'");
            ViewBag.Red = ($"{color.GetColor()} red!'");
            return View();
        }
    }
}
