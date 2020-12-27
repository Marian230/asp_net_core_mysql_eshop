using Microsoft.AspNetCore.Http;
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
            this.ViewBag.CartQuantity = this.Order_ItemsCount();

            return View();
        }

        public int Order_ItemsCount()
        {
            return (from order_item in this.context.Order_Item
                    from order in this.context.Order
                    where order.id == order_item.id_Order
                    where order.cookie_Id == Convert.ToInt32(this.HttpContext.Session.GetString("userId"))
                    select new Order_Item()).Count();
        }
    }
}