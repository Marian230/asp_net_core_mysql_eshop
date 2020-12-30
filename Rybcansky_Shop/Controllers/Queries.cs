using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers
{
    public static class Queries
    {
        private static MyContext context = new MyContext();

        public static List<Product> ReturnAllProducts()
        {
            return Queries.context.Product.ToList();
        }

        public static List<Picture> PictureQuery(Product product)
        {
            return (from productPicture in Queries.context.ProductPicture
                    from picture in Queries.context.Picture
                    where productPicture.id_Product == product.id
                    where productPicture.id_Picture == picture.id
                    select new Picture()
                    {
                        id = picture.id,
                        name = picture.name,
                        order = picture.order,
                        path = picture.path
                    }).ToList();
        }

        public static List<Vendor> VendorQuery(Product product)
        {
            return (from vendor in Queries.context.Vendor
                    where vendor.id == product.id_Vendor
                    select new Vendor()
                    {
                        id = vendor.id,
                        name = vendor.name
                    }).ToList();
        }

        public static List<Variant> VariantQuery(Product product)
        {
            return (from variant in Queries.context.Variant
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
        }
    }
}
