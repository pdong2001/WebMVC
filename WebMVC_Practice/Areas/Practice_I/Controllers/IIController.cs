using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC_Practice.Areas.Practice_I.Controllers
{
    [Area("Practice_I")]
    public class IIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(double A, double B)
        {
            if (A == 0)
            {
                if (B != 0)
                {
                    ViewBag.Result = "Phương trình vô nghiệm";
                }
                else
                {
                    ViewBag.Result = "Phương trình vô số nghiệm";
                }
            }
            else
            {
                ViewBag.Result = -B / A;
            }
            return View();
        }
    }
}
