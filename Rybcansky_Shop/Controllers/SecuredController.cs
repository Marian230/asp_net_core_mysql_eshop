using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Rybcansky_Shop.Controllers
{
    public abstract class SecuredController : AbstractController
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            /*if (!this.Authenticated)
                context.Result = this.RedirectToAction("Index", "Login");*/
        }
    }
}
