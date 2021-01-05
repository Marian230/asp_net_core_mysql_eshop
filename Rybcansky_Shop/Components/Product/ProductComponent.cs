using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Components
{
    public class ProductComponent : ViewComponent
    {
        private MyContext context = new MyContext();

        public IViewComponentResult Invoke(Product product)
        {
            this.ViewBag.Product = product;
            this.ViewBag.Picture = this.PictureQuery(product);
            this.ViewBag.Test = "TEST";

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
    }
}