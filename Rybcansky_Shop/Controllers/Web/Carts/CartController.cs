using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.Web.Carts
{
    public class CartController : AbstractController
    {
        public IActionResult Index()
        {
            this.ViewBag.Data = this.Query();

            return View();
        }

        [HttpPost]
        public  IActionResult Create(Cart_Item item)
        {
            this.context.Cart_Item.Add(item);
            this.context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int id)
        {
            Cart_Item deletedItem = this.context.Cart_Item.Find(id);
            this.context.Cart_Item.Remove(deletedItem);
            this.context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Order()
        {
            this.ViewBag.Items = this.context.Cart_Item.ToList();

            return View();
        }

        private List<CartClass> Query()
        {
            var query = (from cartItem in this.context.Cart_Item
                         from variant in this.context.Variant
                         from product in this.context.Product
                         where cartItem.id_Product_Variant == variant.id
                         where variant.id_Product == product.id
                         select new CartClass()
                         {
                             productName = product.name,
                             productVariantName = variant.color,
                             number = cartItem.quantity,
                             id = cartItem.id
                         }).ToList();

            return query;
        }
    }
}