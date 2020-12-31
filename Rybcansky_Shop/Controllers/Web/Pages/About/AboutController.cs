using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.Web.Pages.About
{
    public class AboutController : UserController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
