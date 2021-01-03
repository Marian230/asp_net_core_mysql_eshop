using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;

namespace Rybcansky_Shop.Controllers
{
    public class TestController : AbstractController
    {
        public IActionResult Index()
        {
            List<Product_Tag> item = this.context.Product_Tag.ToList();

            List<string> returnList = new List<string>();

            foreach (var neco in item)
                returnList.Add(JsonSerializer.Serialize(neco));

            ViewBag.Text = returnList;

            return View();
        }
    }
}