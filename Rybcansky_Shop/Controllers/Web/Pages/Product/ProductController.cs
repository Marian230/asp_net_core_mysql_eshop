using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.Page
{
    public class ProductController : UserController
    {
        public IActionResult Index(int id)
        {
            this.ViewBag.Product = this.context.Product.Find(id);
            this.ViewBag.Sizes = new List<string>()
            {
                "S",
                "M",
                "L",
                "XL"
            };
            this.ViewBag.Colors = new List<string>()
            {
                "Red",
                "Green", 
                "Blue",
                "Yellow",
                "White"
            };
            this.ViewBag.Tags = new List<string>()
            {
                "Blue",
                "Green",
                "M",
                "XL",
            };

            return View();
        }

        public IActionResult First()
        {
            int id = 1;
            this.ViewBag.Product = this.context.Product.Find(id);

            return RedirectToAction("Index", "Product", new { id = id });
        }
    }
}
