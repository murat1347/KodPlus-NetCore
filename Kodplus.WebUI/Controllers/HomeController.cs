using Kodplus.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Kodplus.Business.Interfaces;
using Kodplus.Dataaccess.Entities;

namespace Kodplus.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericService<Article> _articleGenericService;
        private readonly IArticleService _articleService;
        public HomeController(IGenericService<Article> articleGenericService, IArticleService articleService)
        {
            _articleGenericService = articleGenericService;
            _articleService = articleService;
        }


        public IActionResult Index()
        {
            return View(_articleService.GetAll());
        }

        //public IActionResult Details(int id)
        //{
        //    return View(_articleService.));
        //}

        public IActionResult Details(int id)
        {
            ;
            return View(_articleService.GetById(id));
        }

        public IActionResult Add(Article article)
        {
            return View(_articleService.Insert(article));
        }

    }
}
