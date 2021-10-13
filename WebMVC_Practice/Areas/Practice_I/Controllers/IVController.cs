using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC_Practice.Areas.Practice_I.Data;
using WebMVC_Practice.Areas.Practice_I.Models;

namespace WebMVC_Practice.Areas.Practice_I.Controllers
{
    [Area("Practice_I")]
    public class IVController : Controller
    {
        private readonly IStudentService _student;
        public IVController(IStudentService student)
        {
            this._student = student;
        }
        public IActionResult Index()
        {
            return View(_student.GetAll());
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(Student request)
        {
            _student.Add(request);
            return RedirectToAction(actionName: "Index");
        }

        [HttpPost]
        [ActionName("Sort")]
        public IActionResult Sort(int ColNumber)
        {
            _student.Sort(ColNumber);
            return RedirectToAction("Index");
        }
    }
}
