using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Components.Shared
{
    public class TagsComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            this.ViewBag.Tags = new List<string>()
            {
                "bestselling",
                "collection",
                "dress",
                "fashion",
                "men",
                "style",
                "woman"
            };

            return View();
        }
    }
}
