using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;

namespace Rybcansky_Shop.Controllers
{
    public class LoginController : AbstractController
    {
        MyContext context { get; set; } = new MyContext();

        [HttpGet]
        public IActionResult Index()
        {
            return View(new LoginForm());
        }

        [HttpPost]
        public IActionResult Index(LoginForm form)
        {
            if (this.ModelState.IsValid && this.IsLoginValid(form))
            {
                this.HttpContext.Session.SetString("login", form.login);
                return this.RedirectToAction("Index", "Home");
            }

            return View(form);
        }

        public IActionResult Logout()
        {
            this.HttpContext.Session.Remove("login");
            return RedirectToAction("Index");
        }

        private bool IsLoginValid(LoginForm form)
        {
            foreach (var admin in this.context.Admin.ToList())
            {
                if (form.login == admin.username && form.password == admin.password)
                    return true;
            }
            return false;
        }
    }
}