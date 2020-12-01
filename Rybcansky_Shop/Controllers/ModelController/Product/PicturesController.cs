using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.ModelController
{
    public class PicturesController : SecuredTemplateController<Picture>
    {
        public override IActionResult Index()
        {
            this.ViewBag.Items = this.PicturesQuery();
            return View();
        }

        public IActionResult CreateFromId(int id)
        {
            this.HttpContext.Session.SetString("id_Product", id.ToString());
            this.listOfItem = this.PicturesQuery();
            this.ViewBag.Items = this.listOfItem;

            return Index(); 
        }

        public override IActionResult Detail(int id)
        {
            //this.ViewBag.Item = this.listOfItem.Find(x => x.id == id);
            this.ViewBag.Item = this.listOfItem.Find(x => x.id == id);
            return base.Detail(id);
        }

        public override IActionResult Create(Picture item) // TODO
        {
            if (this.ModelState.IsValid)
            {
                //ProductPicture productPicture = new ProductPicture();

                this.useContext.Add(item);
                this.context.SaveChanges();

                return RedirectToAction("Confirm");
            }

            return View(item);
        }

        private List<Picture> PicturesQuery()
        {
            int id = Int32.Parse(this.HttpContext.Session.GetString("id_Product").ToString());
            var query = (from productPicture in this.context.ProductPicture
                         where productPicture.id_Product == id
                         join picture in this.context.Picture on productPicture.id_Picture equals picture.id
                         select new Picture() 
                         {
                             id = picture.id,
                             name = picture.name,
                             order = picture.order,
                             path = picture.path
                         }).ToList();

            return query;
        }
    }
}