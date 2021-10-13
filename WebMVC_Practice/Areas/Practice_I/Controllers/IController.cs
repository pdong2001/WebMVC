using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC_Practice.Areas.Practice_I.Controllers
{
    [Area("Practice_I")]
    public class IController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Name)
        {
            ViewBag.Name = $"Hello {Name}";
            return View();
        }
    }
}
