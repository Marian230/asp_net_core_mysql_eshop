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
    public class UserController : Controller
    {
        protected MyContext context { get; set; } = new MyContext();

        protected Random random { get; set; } = new Random();

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (this.HttpContext.Session.GetString("userId") == null)
            {
                int cookieID = this.random.Next(0, int.MaxValue);
                //this.HttpContext.Session.Remove("userId");
                this.context.Order.Add(new Order() { cookie_Id = cookieID });
                this.context.SaveChanges();
                this.HttpContext.Session.SetString("userId", cookieID.ToString());
            }

            base.OnActionExecuting(context);
        }
    }
}