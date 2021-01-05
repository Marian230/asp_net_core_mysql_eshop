using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
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
            this.ViewBag.Tags = this.context.Tag.Where(x => x.is_Product == false).ToList();

            this.ViewBag.Comments = this.context.Comment.ToList();
            this.ViewBag.Data = this.GetData(id);

            return View();
        }

        public IActionResult MakeComment(Comment commment)
        {
            commment.time = DateTime.Now;

            this.context.Comment.Add(commment);
            this.context.SaveChanges();

            return RedirectToAction("Detail", new { id = commment.id_Article });
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

        private BlogDetailData GetData(int id)
        {
            BlogDetailData data = (from article in this.context.Article
                                   from picture in this.context.Picture
                                   where article.id == id
                                   where picture.id == article.id_Picture
                                   select new BlogDetailData()
                                   {
                                       Article = article,
                                       Picture = picture
                                   }).ToList()[0];

            data.Comments = (from comment in this.context.Comment
                             where comment.id_Article == data.Article.id
                             select comment).ToList();

            data.Tags = (from tag in this.context.Tag
                            from article_tag in this.context.Article_Tag
                            where article_tag.id_Article == data.Article.id
                            where article_tag.id_Tag == tag.id
                            select tag).ToList();

            return data;
        }
    }

    public class BlogDetailData
    {
        public Article Article { get; set; }

        public Picture Picture { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Tag> Tags { get; set; }
    }
}
