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

        public static double ExpireTime { get; set; } = 3600;

        public static string userId { get; set; } = "userId";

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var orders = this.context.Order.Where(x => x.finished == false);

            foreach (var item in orders)
            {
                if (DateTime.Now - item.last_Acces_Time > TimeSpan.FromSeconds(ExpireTime))
                    this.context.Remove(this.context.Order.Find(item.id));
            }
            this.context.SaveChanges();

            if (this.HttpContext.Session.GetString(UserController.userId) == null)
            {
                int cookieID = this.random.Next(0, int.MaxValue);
                this.context.Order.Add(new Order() { cookie_Id = cookieID, last_Acces_Time = DateTime.Now });
                this.context.SaveChanges();
                this.HttpContext.Session.SetString(UserController.userId, cookieID.ToString());
            }

            base.OnActionExecuting(context);
        }
    }
}