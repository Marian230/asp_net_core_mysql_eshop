using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Controllers;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Components
{
    public class ProductDetailComponent : ViewComponent
    {
        private MyContext context = new MyContext();

        public IViewComponentResult Invoke(Product product)
        {
            this.ViewBag.Product = product;
            this.ViewBag.Picture = Queries.PictureQuery(product);
            this.ViewBag.Vendor = Queries.VendorQuery(product);

            this.ViewBag.Cart = this.GetMyOrder();

            this.ViewBag.Variants = Queries.VariantQuery(product);

            return View();
        }

        private Order GetMyOrder()
        {
            Order cart = null;
            foreach (var item in this.context.Order)
            {
                if (item.cookie_Id == Convert.ToInt32(this.HttpContext.Session.GetString("userId")))
                {
                    cart = item;
                    break;
                }
            }

            return cart;
        }
    }
}