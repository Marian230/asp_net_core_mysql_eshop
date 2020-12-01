using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;

namespace Rybcansky_Shop.Controllers
{
    public class AdministrationController : SecuredController
    {
        public IActionResult Index()
        {
            this.ViewBag.Models = new List<string>()
            {
                "Admins",
                "Articles",
                "Category",
                "Payment_Methods",

                "Products",
                "Shipping_Methods",
                "Vendors"
            };

            return View();
        }
    }
}
