using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.Web.Carts
{
    public class CartController : UserController
    {
        public IActionResult Index()
        {
            List<CartClass> items = this.Query();

            //this.ViewBag.Cookie = this.HttpContext.Session.GetString("userId");
            this.ViewBag.Data = items;
            this.ViewBag.totalPrice = this.TotalPrice(items);

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

        [HttpPost]
        public IActionResult CreateOld(Cart_Item item)
        {
            /*int? id = null;
            foreach (var contextItem in this.context.Cart_Item)
            {
                if (contextItem.id_Product_Variant == item.id_Product_Variant)
                {
                    id = contextItem.id;
                    break;
                }
            }

            if (id != null)
            {
                this.context.Cart_Item.Find(id).quantity++;
                this.context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            this.context.Cart_Item.Add(item);
            this.context.SaveChanges();*/

            return RedirectToAction("Index", "Home");

        }

        public IActionResult Delete(int id)
        {
            /*Cart_Item deletedItem = this.context.Cart_Item.Find(id);
            this.context.Cart_Item.Remove(deletedItem);
            this.context.SaveChanges();*/

            
            Order_Item deletedItem = this.context.Order_Item.Find(id);
            this.context.Order_Item.Remove(deletedItem);
            this.context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Order()
        {
            /*List<CartClass> cartList = this.Query();
            this.ViewBag.Items = this.context.Cart_Item;
            this.ViewBag.Price = this.TotalPrice(cartList);*/



            return View();
        }

        private List<CartClass> QueryOld()
        {
            /*var query = (from cartItem in this.context.Cart_Item
                         from variant in this.context.Variant
                         from product in this.context.Product
                         from picture in this.context.Picture
                         from productPicture in this.context.ProductPicture
                         where productPicture.id_Product == product.id
                         where picture.id == productPicture.id_Picture
                         where picture.order == 0
                         where cartItem.id_Product_Variant == variant.id
                         where variant.id_Product == product.id
                         select new CartClass()
                         {
                             id = cartItem.id,
                             quantity = cartItem.quantity,
                             picture = picture.path,
                             ProductName = product.name,
                             VariantName = variant.color,
                             variantPriceStandart = variant.price_Standart,
                             variantPriceDiscount = variant.price_Discount
                         }).ToList();

            return query;*/

            return null;
        }

        private List<CartClass> Query()
        {
            //int cookie = Convert.ToInt32(this.ViewBag.Cookie);

            var query = (from cartItem in this.context.Order_Item
                         from variant in this.context.Variant
                         from product in this.context.Product
                         from picture in this.context.Picture
                         from productPicture in this.context.ProductPicture

                         from order in this.context.Order
                         where cartItem.id_Order == order.id

                         where order.cookie_Id == Convert.ToInt32(this.HttpContext.Session.GetString("userId"))

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
                         }).ToList();

            return query;
        }

        private double TotalPrice(List<CartClass> totalItems)
        {
            double totalPrice = 0;

            for (int i = 0; i < totalItems.Count; i++)
            {
                double price = Convert.ToDouble(totalItems[i].variantPriceDiscount ?? totalItems[i].variantPriceStandart);
                totalPrice += price * totalItems[i].quantity;
            }

            return totalPrice;
        }
    }
}