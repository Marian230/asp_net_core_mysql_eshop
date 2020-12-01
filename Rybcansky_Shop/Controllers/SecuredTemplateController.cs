using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers
{
    public class SecuredTemplateController<T> : TemplateController<T> where T : TemplateModel
    {
        public bool Authenticated { get; set; }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            this.Authenticated = this.HttpContext.Session.GetString("login") != null;
            this.ViewBag.Authenticated = this.Authenticated;

            /*if (!this.Authenticated)
                context.Result = this.RedirectToAction("Index", "Login");*/
        }

        public override IActionResult Index()
        {
            return base.Index();
        }
    }
}
