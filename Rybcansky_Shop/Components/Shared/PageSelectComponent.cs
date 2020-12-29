using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Components.Shared
{
    public class PageSelectComponent : ViewComponent
    {
        MyContext context = new MyContext();

        public IViewComponentResult Invoke()
        {
            this.ViewBag.pageOptions = new List<string>()
            {
                "Prev",
                "1",
                "2",
                "3",
                "4",
                "Next"
            };

            return View();
        }
    }
}
