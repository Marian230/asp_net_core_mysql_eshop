using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Components.Shared
{
    public class BlogMenuComponent : ViewComponent
    {
        MyContext context = new MyContext();

        public IViewComponentResult Invoke()
        {
            this.ViewBag.Tags = this.context.Tag.Where(x => x.is_Product == false).ToList();

            return View();
        }
    }
}
