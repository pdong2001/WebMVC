using Microsoft.AspNetCore.Mvc;
using Models.Entity;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC_Practice.Areas.Practice_II.Controllers
{
    [Area("Practice_II")]
    public class ArticleAdminController : Controller
    {
        private readonly IArticleService _article;

        public ArticleAdminController(IArticleService article)
        {
            _article = article;
        }

        public IActionResult Index()
        {
            return View(_article.GetAll());
        }
    }
}
