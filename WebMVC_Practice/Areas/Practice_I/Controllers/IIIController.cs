using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC_Practice.Areas.Practice_I.Controllers
{
    [Area("Practice_I")]
    public class IIIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Index")]
        public IActionResult Compute(double A, double B, double C)
        {
            double delta = B * B - 4 * A * C;
            if (delta > 0)
            {
                ViewBag.Result = new double[] { (-B - Math.Sqrt(delta)) / 2 * A,(-B + Math.Sqrt(delta)) / 2 * A};
            }
            else if (delta == 0)
            {
                ViewBag.Result = new double[] { -B / 2 * A, -B / 2 * A };
            }
            else if (delta < 0)
            {
                ViewBag.Result= "Phương trình vô nghiệm.";
            }
            return View();
        }
    }
}
