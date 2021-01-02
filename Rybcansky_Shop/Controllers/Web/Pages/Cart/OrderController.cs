using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.Web.Carts
{
    public class OrderController : UserController
    {
        public IActionResult Index()
        {
            var cookie = Request.Cookies["userId"];
            this.ViewBag.Cookie = cookie ?? "EMPTY";
            this.ViewBag.Data = this.Query();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Order_Item item)
        {
            int? id = null;
            foreach (var contextItem in this.context.Order_Item)
            {
                if (contextItem.id_Product == item.id_Product)
                {
                    id = contextItem.id;
                    break;
                }
            }

            if (id != null)
            {
                this.context.Order_Item.Find(id).quantity += item.quantity;
                this.context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            this.context.Order_Item.Add(item);
            this.context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int id)
        {
            Order_Item deletedItem = this.context.Order_Item.Find(id);
            this.context.Order_Item.Remove(deletedItem);
            this.context.SaveChanges();

            return RedirectToAction("Index");
        }

        private List<CartClass> Query()
        {
            int cookie = Convert.ToInt32(this.ViewBag.Cookie);

            var query = (from cartItem in this.context.Order_Item
                         from variant in this.context.Variant
                         from product in this.context.Product
                         from picture in this.context.Picture
                         from productPicture in this.context.ProductPicture

                         from order in this.context.Order
                         where cartItem.id_Order == order.id
                         //where order.cookie_Id == cookie

                         where productPicture.id_Product == product.id
                         where picture.id == productPicture.id_Picture
                         where picture.order == 0
                         where cartItem.id_Product == variant.id
                         where variant.id_Product == product.id
                         select new CartClass()
                         {
                             id = cartItem.id,
                             quantity = cartItem.quantity,
                             ProductName = product.name,
                             VariantName = variant.color,
                             variantPriceStandart = variant.price_Standart,
                             variantPriceDiscount = variant.price_Discount,
                             picture = picture.path,
                             //Order_item = cartItem
                         }).ToList();

            return query;
        }
    }
}
