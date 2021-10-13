using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC_Practice.Areas.Practice_II.Controllers
{
    [Area("Practice_II")]
    public class ShopAdminController : Controller
    {
        private readonly IUserService _user;

        public ShopAdminController(IUserService user)
        {
            _user = user;
        }

        public IActionResult Index()
        {
            return View(_user.GetAll());
        }
    }
}
