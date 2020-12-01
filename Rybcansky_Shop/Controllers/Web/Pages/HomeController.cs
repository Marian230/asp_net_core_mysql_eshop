using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rybcansky_Shop.Models;

namespace Rybcansky_Shop.Controllers
{
    public class HomeController : AbstractController
    {
        public IActionResult Index()
        {
            this.ViewBag.Products = this.context.Product.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /*public object PictureQuery()
        {
            return;
        }*/
    }
}
