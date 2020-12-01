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
        private MyContext context { get; set; } = new MyContext();

        private List<Tag> Items { get; set; }

        public TestController()
        {
            //this.Items = this.context.Tag.ToList();
        }

        public IActionResult Index()
        {
            /*var item = (from product in this.context.Product
                        from category in this.context.Category
                        where product.id == 1
                        where product.id_Category == category.id
                        select new { category.name, category.id, productID = product.id }).ToList();*/

            object item = (from variant in this.context.Variant
                        where variant.id_Product == 1
                        select new { newVariant = variant});

            List<string> returnList = new List<string>();

            foreach (Variant neco in (List<Variant>)item)
                returnList.Add(JsonSerializer.Serialize(neco));

            /*foreach (var item in Items)
                returnList.Add(JsonSerializer.Serialize(item));*/

            ViewBag.Text = returnList;

            return View();
        }
    }
}