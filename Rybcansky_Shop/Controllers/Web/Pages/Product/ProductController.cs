using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.Page
{
    public class ProductController  : UserController
    {
        public IActionResult Index(int id)
        {
            //if (id != null)
                this.ViewBag.SpecProduct = this.context.Product.Find(id);

            return View();
        }
    }
}
