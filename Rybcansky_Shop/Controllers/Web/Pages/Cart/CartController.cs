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

            this.ViewBag.Data = items;
            this.ViewBag.totalPrice = this.GetTotalPrice();

            return View();
        }

        public IActionResult Order()
        {
            this.ViewBag.Countries = new List<string>()
            {
                "Czechia",
                "Slovakia",
                "Poland",
                "Hungary",
                "Germany",
                "Austria"
            };


            return View();
        }

        public IActionResult Shipping(FormClass items)
        {
            int idOrder = this.GetIdOrder();
            this.context.Contact_Info.Add(items.Contact_Info);
            this.context.SaveChanges();

            this.context.Billing_Adress.Add(items.billing_Adress);
            this.context.SaveChanges();

            //Contact_info id
            var contact_infos = this.context.Contact_Info.ToList();
            int idContac = contact_infos[contact_infos.Count() - 1].id;

            // Billing_info id
            var billing_addresses = this.context.Billing_Adress.ToList();
            int idBilling = billing_addresses[billing_addresses.Count() - 1].id;

            this.context.Order.Where(x => x.id == this.GetIdOrder()).FirstOrDefault().id_Contact_Info = idContac;
            this.context.Order.Where(x => x.id == this.GetIdOrder()).FirstOrDefault().id_Primary_Billing_Adress = idBilling;
            this.context.SaveChanges();

            this.ViewBag.PaymentMethods = this.context.Payment_Methods.ToList();

            Order order = this.context.Order.Where(x => x.id == idOrder).ToList()[0];
            this.ViewBag.Email = this.context.Contact_Info.Where(x => x.id == order.id_Contact_Info).ToList()[0].email;

            Billing_Adress address = this.context.Billing_Adress.Where(x => x.id == order.id_Primary_Billing_Adress).ToList()[0];
            string shippTo = string.Concat(address.address, ", ", address.appartmant, ", ", address.postal_Code, ", ", address.city, ", ", address.country);
            this.ViewBag.Shipping = shippTo;

            return View();
        }

        public IActionResult Payment(FormClass items)
        {
            int idOrder = this.GetIdOrder();
            this.ViewBag.PaymentMethods = this.context.Payment_Methods.ToList();
            this.ViewBag.Countries = new List<string>()
            {
                "Czechia",
                "Slovakia",
                "Poland",
                "Hungary",
                "Germany",
                "Austria"
            };

            this.context.Order
                .Where(x => x.id == idOrder)
                .FirstOrDefault().id_Payment_Methods = Convert.ToInt32(items.Payment_Methods.method);
            this.context.SaveChanges();

            Order order = this.context.Order.Where(x => x.id == idOrder).ToList()[0];
            this.ViewBag.Email = this.context.Contact_Info.Where(x => x.id == order.id_Contact_Info).ToList()[0].email;

            Billing_Adress address = this.context.Billing_Adress.Where(x => x.id == order.id_Primary_Billing_Adress).ToList()[0];
            string shippTo = string.Concat(address.address, ", ", address.appartmant, ", ", address.postal_Code, ", ", address.city, ", ", address.country);
            this.ViewBag.Shipping = shippTo;

            return View();
        }

        public IActionResult FinishOrder(FormClass items)
        {
            Billing_Adress address = items.billing_Adress;

            this.context.Billing_Adress.Add(address);
            this.context.SaveChanges();

            //int id = this.context.Billing_Adress.Last().id;
            List<Billing_Adress> tmpAddresses = this.context.Billing_Adress.ToList();
            int id = tmpAddresses[tmpAddresses.Count() - 1].id;

            this.context.Order.Where(x => x.id == this.GetIdOrder()).FirstOrDefault().id_Different_Billing_Adress = id;
            this.context.Order.Where(x => x.id == this.GetIdOrder()).FirstOrDefault().finished = true;
            this.context.SaveChanges();

            return RedirectToAction("Complete");
        }

        public IActionResult Complete()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Create(Order_Item item)
        {
            int? id = null;
            List<Order_Item> order_items = (from order in this.context.Order
                                            from order_item in this.context.Order_Item
                                            where order.id == order_item.id_Order
                                            where order.cookie_Id == Convert.ToInt32(this.HttpContext.Session.GetString("userId"))
                                            select new Order_Item()
                                            {
                                                id = order_item.id,
                                                id_Product = order_item.id_Product
                                            }).ToList();

            foreach (var contextItem in order_items)
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

        private double GetTotalPrice()
        {
            int cookie_id = Convert.ToInt32(this.HttpContext.Session.GetString(UserController.userId));
            int idOrder = this.context.Order.Where(x => x.cookie_Id == cookie_id).ToList()[0].id;

            var neco = (from order_item in this.context.Order_Item
                        from product in this.context.Product
                        from variant in this.context.Variant
                        where order_item.id_Order == idOrder
                        where order_item.id_Product == variant.id
                        where product.id == variant.id_Product
                        select order_item).ToList();

            double totalprice = 0;
            foreach (Order_Item item in neco)
            {
                Variant variant = this.context.Variant.Where(x => x.id == item.id_Product).ToList()[0];
                double price = Convert.ToDouble(variant.price_Discount ?? variant.price_Standart);

                totalprice += (item.quantity * price);
            }

            return totalprice;
        }

        private int GetIdOrder()
        {
            int cookie_id = Convert.ToInt32(this.HttpContext.Session.GetString(UserController.userId));
            return this.context.Order.Where(x => x.cookie_Id == cookie_id).ToList()[0].id;
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
            var query = (from cartItem in this.context.Order_Item
                         from variant in this.context.Variant
                         from product in this.context.Product
                         from picture in this.context.Picture
                         from productPicture in this.context.ProductPicture

                         from order in this.context.Order
                         where cartItem.id_Order == order.id

                         where order.cookie_Id == Convert.ToInt32(this.HttpContext.Session.GetString("userId"))

                         where order.finished == false

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

    public class FormClass
    {
        public Billing_Adress billing_Adress { get; set; } = new Billing_Adress();

        public Contact_Info Contact_Info { get; set; } = new Contact_Info();

        public Payment_Methods Payment_Methods { get; set; } = new Payment_Methods();

        public Shipping_Method Shipping_Method { get; set; } = new Shipping_Method();
    }
}