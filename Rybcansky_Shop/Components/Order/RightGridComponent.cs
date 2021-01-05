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
    public class RightGridComponent : ViewComponent
    {
        private MyContext context = new MyContext();

        public IViewComponentResult Invoke()
        {
            this.ViewBag.Data = this.GetData();
            this.ViewBag.TotalPrice = this.GetTotalPrice();

            return View();
        }

        public List<Data> GetData()
        {
            int cookie_id = Convert.ToInt32(this.HttpContext.Session.GetString(UserController.userId));
            int idOrder = this.context.Order.Where(x => x.cookie_Id == cookie_id).ToList()[0].id;

            List<Product> products_ = (from order_item in this.context.Order_Item
                    from product in this.context.Product
                    from variant in this.context.Variant
                    where order_item.id_Order == idOrder
                    where order_item.id_Product == variant.id
                    where product.id == variant.id_Product
                    select product).ToList();

            List<ProductPicture> product_pictures_ = (from products in products_
                                                      from product_pictures in this.context.ProductPicture
                                                      where product_pictures.id_Product == products.id
                                                      select product_pictures).ToList();

            List<Picture> pictures = new List<Picture>();

            foreach (var item in product_pictures_)
                pictures.Add(this.context.Picture.Where(x => x.id == item.id_Picture).ToList()[0]);

            List<Data> returnData = new List<Data>();
            for (int i = 0; i < products_.Count; i++)
                returnData.Add(new Data() { product = products_[i], picture = pictures[i]});

            return returnData;
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
    }
    public class Data
    {
        public Product product { get; set; }

        public Picture picture { get; set; }
    }
}
