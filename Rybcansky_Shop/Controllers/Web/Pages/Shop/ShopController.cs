using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.Web.Pages.Shop
{
    public class ShopController : UserController
    {
        public IActionResult Index()
        {
            this.ViewBag.sortingOptions = new List<string>
            {
                "Alphabetically, A-Z",
                "Alphabetically, Z-A",
                "Price, low to high",
                "Price, high to low",
                "Date, new to old",
                "Date, old to new"
            };

            this.ViewBag.Products = Queries.ReturnAllProducts();

            this.ViewBag.Vendors = this.context.Vendor.Select(x => x.name).ToList();

            this.ViewBag.Sizes = this.context.Size.ToList();

            this.ViewBag.Tags = new List<string>()
            {
                "Black",
                "Blue",
                "Fiber",
                "Gold",
                "Gray"
            };

            return View();
        }
    }
}
