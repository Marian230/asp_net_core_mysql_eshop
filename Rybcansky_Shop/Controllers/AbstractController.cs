using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Rybcansky_Shop.Models;

namespace Rybcansky_Shop.Controllers
{
    public abstract class AbstractController : Controller
    {
        protected MyContext context { get; set; } = new MyContext();

        public bool Authenticated { get; set; }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            this.Authenticated = this.HttpContext.Session.GetString("login") != null;
            this.ViewBag.Authenticated = this.Authenticated;
        }
    }
}