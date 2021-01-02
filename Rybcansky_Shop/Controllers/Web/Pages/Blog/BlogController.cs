using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.Web.Blog
{
    public class BlogController : UserController
    {
        public IActionResult Index()
        {
            this.ViewBag.Data = this.Query();

            return View();
        }

        public IActionResult Detail(int id)
        {
            this.ViewBag.id = id;
            this.ViewBag.Tags = new List<string>()
            {
                "bestselling",
                "collection",
                "dress",
                "fashion",
                "men",
                "style",
                "woman"
            };

            this.ViewBag.Comments = this.context.Comment.ToList();

            return View();
        }

        private List<BlogListClass> Query()
        {
            var query = (from article in this.context.Article
                         from picture in this.context.Picture
                         where picture.id == article.id_Picture
                         select new BlogListClass()
                         {
                             Picture = picture,
                             Article = article
                         }).ToList();

            return query;
        }
    }
}
