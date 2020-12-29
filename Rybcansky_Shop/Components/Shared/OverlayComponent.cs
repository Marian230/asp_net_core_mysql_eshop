using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Components.Shared
{
    public class OverlayComponent : ViewComponent
    {
        MyContext context = new MyContext();

        public IViewComponentResult Invoke(string name)
        {
            this.ViewBag.name = name;

            return View();
        }
    }
}
