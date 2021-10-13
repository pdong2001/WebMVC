using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC_Practice.Areas.Practice_II.Controllers
{
    [Area("Practice_II")]
    public class ShopController : Controller
    {
        private readonly IProductService _product;

        public ShopController(IProductService product)
        {
            _product = product;
        }

        public IActionResult Index()
        {
            return View(_product.GetAll());
        }
    }
}
