using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Components
{
    public class ProductDetailComponent : ViewComponent
    {
        MyContext context = new MyContext();

        public IViewComponentResult Invoke(Product product)
        {
            //this.ViewBag.Product = this.context.Product.Find(id);
            this.ViewBag.Product = product;
            this.ViewBag.Picture = this.PictureQuery(product);
            this.ViewBag.Vendor = this.VendorQuery(product);
            this.ViewBag.Cart = this.context.Cart.First();
            this.ViewBag.Variants = VariantQuery(product);

            return View();
        }

        private Picture PictureQuery(Product product)
        {
            var query = (from productPicture in this.context.ProductPicture
                         from picture in this.context.Picture
                         where productPicture.id_Product == product.id
                         where productPicture.id_Picture == picture.id
                         select new Picture()
                         {
                             id = picture.id,
                             name = picture.name,
                             order = picture.order,
                             path = picture.path
                         });

            return query.First();
        }

        private Vendor VendorQuery(Product product)
        {
            var query = (from vendor in this.context.Vendor
                         where vendor.id == product.id_Vendor
                         select new Vendor()
                         {
                             id = vendor.id,
                             name = vendor.name
                         });

            return query.First();
        }

        private List<Variant> VariantQuery(Product product)
        {
            var query = (from variant in this.context.Variant
                         where variant.id_Product == product.id
                         select new Variant()
                         {
                             id = variant.id,
                             number = variant.number,
                             price_Standart = variant.price_Standart,
                             price_Discount = variant.price_Discount,
                             stock_Number = variant.stock_Number,
                             size = variant.size,
                             color = variant.color,
                             id_Product = variant.id_Product
                         }).ToList();
            return query;
        }
    }
}