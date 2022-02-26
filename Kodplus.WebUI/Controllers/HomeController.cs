using Kodplus.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Kodplus.Business.Interfaces;
using Kodplus.Dataaccess.Entities;

namespace Kodplus.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericService<Article> _articleGenericService;
       
        public HomeController(IGenericService<Article> articleGenericService)
        {
            _articleGenericService = articleGenericService;
        }


        public IActionResult Index()
        {
            return View(_articleGenericService.GetAll());
        }

        //public IActionResult Details(int id)
        //{
        //    return View(_articleService.));
        //}

        public IActionResult Details(int id)
        {
            var article = _articleGenericService.GetById(id);
            
            return View(article);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Article article)
        {
            _articleGenericService.Insert(article);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var values = _articleGenericService.GetById(id);
            return View();
        }
        [HttpPost]
        public IActionResult Update(Article article)
        {
            _articleGenericService.Update(article);
            return View();
        }

        [HttpGet]

        public IActionResult Delete(int id)
        {
            var values = _articleGenericService.GetById(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult Delete(Article article)
        {
            _articleGenericService.Delete(article);
            return View();
        }
    }
}
