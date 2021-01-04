using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.Page
{
    public class ProductController : UserController
    {
        public IActionResult Index(int id)
        {
            this.ViewBag.Product = this.context.Product.Find(id);
            this.ViewBag.Sizes = this.GetSizes(id);
            this.ViewBag.Variants = this.context.Variant.Where(x => x.id_Product == id).ToList();
            this.ViewBag.Tags = this.GetTags(id);

            this.ViewBag.Vendor = GetVendor(id);
            this.ViewBag.Pictures = this.GePictures(id);

            int cookie_id = Convert.ToInt32(this.HttpContext.Session.GetString(UserController.userId));
            this.ViewBag.CartId = this.context.Order.Where(x => x.cookie_Id == cookie_id).ToList()[0].id;

            return View();
        }

        public IActionResult First()
        {
            int id = 1;
            this.ViewBag.Product = this.context.Product.Find(id);

            return RedirectToAction("Index", "Product", new { id = id });
        }

        private List<Size> GetSizes(int id)
        {
           return (from size in this.context.Size
                     from product_size in this.context.Product_Size
                     where product_size.id_Product == id
                     where product_size.id_Size == size.id
                     select size).ToList();
        }

        private List<Tag> GetTags(int id)
        {
            return (from tag in this.context.Tag
                    from product_tag in this.context.Product_Tag
                    where product_tag.id_Product == id
                    where product_tag.id_Tag == tag.id
                    select tag).ToList();
        }

        private Vendor GetVendor(int id)
        {
            return (from vendor in this.context.Vendor
                    from product in this.context.Product.Where(x => x.id == id)
                    where vendor.id == product.id_Vendor
                    select vendor).ToList()[0];
        }

        private List<Picture> GePictures(int id)
        {
            return (from picture in this.context.Picture
                    from product_picture in this.context.ProductPicture
                    where product_picture.id_Picture == picture.id
                    where product_picture.id_Product == id
                    select picture).ToList();
        }
    }
}
