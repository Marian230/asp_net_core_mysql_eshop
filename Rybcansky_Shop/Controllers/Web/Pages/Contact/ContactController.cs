using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.Web.Pages.Contact
{
    public class ContactController : UserController
    {
        public IActionResult Index()
        {
            return View();
        }

        //TODO 
        [HttpPost]
        public IActionResult Message()
        {
            return View();
        }
    }
}
