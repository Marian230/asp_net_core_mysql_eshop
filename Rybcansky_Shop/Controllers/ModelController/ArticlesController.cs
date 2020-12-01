using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;

namespace Rybcansky_Shop.Controllers.AdminControllers
{
    public class ArticlesController : SecuredTemplateController<Article>
    {
        /*private MyContext context { get; set; } = new MyContext();

        private List<Article> articles { get; set; }

        public ArticlesController()
        {
            this.articles = context.Article.ToList();
        }

        public IActionResult Index()
        {
            this.ViewBag.Articles = this.articles;

            return View();
        }

        public IActionResult Detail(int id)
        {
            this.ViewBag.Article = this.articles.Find(x => x.id == id);

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Article());
        }

        [HttpPost]
        public IActionResult Create(Article article)
        {
            if (this.ModelState.IsValid)
            {
                this.context.Article.Add(article);
                this.context.SaveChanges();

                return RedirectToAction("Confirm");
            }

            return View(article);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            this.ViewBag.Article = this.articles.Find(x => x.id == id);
            return View(this.context.Article.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Article article) 
        {
            if (this.ModelState.IsValid)
            {
                Article db = this.context.Article.Find(article.id);
                context.Entry(db).CurrentValues.SetValues(article);

                context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(article);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(this.context.Article.Find(id));
        }

        [HttpPost]
        public IActionResult Delete(Article article)
        {
            this.context.Remove(context.Article.Find(article.id));
            context.SaveChanges();
            return RedirectToAction("Confirm");
        }

        public IActionResult Confirm()
        {
            return View();
        }*/
    }
}
