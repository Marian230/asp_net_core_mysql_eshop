using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Components
{
    public class ComponentTemplate : ViewComponent
    {
        protected MyContext context { get; set; }

        public virtual IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
