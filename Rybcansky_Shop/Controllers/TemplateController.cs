using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rybcansky_Shop.Models;

namespace Rybcansky_Shop.Controllers
{
    // Copyright © - všechná práva vyhrazena 😠
    public class TemplateController<T> : Controller where T : TemplateModel
    {
        protected MyContext context { get; set; } = new MyContext();

        protected DbSet<T> useContext { get; set; }

        protected List<T> listOfItem { get; set; }

        public TemplateController()
        {
            this.useContext = this.context.Set<T>();
            this.listOfItem = useContext.ToList();
        }

        public virtual IActionResult Index()
        {
            this.ViewBag.Items = this.listOfItem;

            return View();
        }

        public virtual IActionResult Detail(int id)
        {
            this.ViewBag.Item = this.listOfItem.Find(x => x.id == id);

            return View(this.useContext.Find(id));
        }

        [HttpGet]
        public virtual IActionResult Create()
        {
            return View(Activator.CreateInstance(typeof(T)));
        }

        [HttpPost]
        public virtual IActionResult Create(T item)
        {
            if (this.ModelState.IsValid)
            {
                this.useContext.Add(item);
                this.context.SaveChanges();

                return RedirectToAction("Confirm");
            }

            return View(item);
        }

        [HttpGet]
        public virtual IActionResult Edit(int id)
        {
            this.ViewBag.Item = this.listOfItem.Find(x => x.id == id);
            return View(this.useContext.Find(id));
        }

        [HttpPost]
        public virtual IActionResult Edit(T item) 
        {
            if (this.ModelState.IsValid)
            {
                T db = this.useContext.Find(item.id);
                context.Entry(db).CurrentValues.SetValues(item);

                context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(item);
        }

        [HttpGet]
        public virtual IActionResult Delete(int id)
        {
            return View(this.useContext.Find(id));
        }

        [HttpPost]
        public virtual IActionResult Delete(Article item)
        {
            this.useContext.Remove(useContext.Find(item.id));
            context.SaveChanges();

            return RedirectToAction("Confirm");
        }

        public virtual IActionResult Confirm()
        {
            return View();
        }
    }
}
