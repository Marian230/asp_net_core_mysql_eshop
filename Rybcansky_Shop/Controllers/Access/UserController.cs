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

        Random random = new Random();

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (Request.Cookies["userId"] == null)
            {
                int id = random.Next(0, Int32.MaxValue);
                
                this.context.Order.Add ( new Order() { cookie_Id = id } );
                Response.Cookies.Append("userId", id + "");
            }

            base.OnActionExecuting(context);
        }
    }
}