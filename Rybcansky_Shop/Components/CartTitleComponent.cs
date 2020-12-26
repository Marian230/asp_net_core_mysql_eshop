using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Components
{
    public class CartTitleComponent : ViewComponent
    {
        public MyContext context { get; set; } = new MyContext();

        public IViewComponentResult Invoke ()
        {
            //List<Cart_Item> list = this.context.Cart_Item.ToList();
            
            //this.ViewBag.CartQuantity = this.context.Cart_Item.Count();
            this.ViewBag.CartQuantity = this.context.Order_Item.Count();

            return View();
        }
    }
}
