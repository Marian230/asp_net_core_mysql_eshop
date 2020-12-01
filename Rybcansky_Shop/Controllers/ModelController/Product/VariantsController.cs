using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.ModelController.Product
{
    public class VariantsController : SecuredTemplateController<Variant>
    {
        public override IActionResult Index()
        {
            this.ViewBag.Items = this.VariantQuery();
            return View();
        }

        public IActionResult CreateFromId(int id)
        {
            this.HttpContext.Session.SetString("id_Product", id.ToString());
            this.listOfItem = this.VariantQuery();
            this.ViewBag.Items = this.listOfItem;

            return Index();
        }

        public override IActionResult Create(Variant article)
        {
            article.id_Product = Int32.Parse(this.HttpContext.Session.GetString("id_Product"));
            return base.Create(article);
        }

        public override IActionResult Edit(Variant article)
        {
            article.id_Product = Int32.Parse(this.HttpContext.Session.GetString("id_Product"));

            return base.Edit(article);
        }

        private List<Variant> VariantQuery()
        {
            int id = Int32.Parse(this.HttpContext.Session.GetString("id_Product").ToString());
            var query = (from variant in this.context.Variant
                         where variant.id_Product == id
                         select new Variant()
                         {
                             id = variant.id,
                             size = variant.size,
                             color = variant.color,
                             number = variant.number,
                             stock_Number = variant.stock_Number,
                             price_Standart = variant.price_Standart,
                             price_Discount = variant.price_Discount
                         }).ToList();

            return query;
        }
    }
}
