using Microsoft.AspNetCore.Mvc;
using Rybcansky_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers
{
    public static class Queries 
    {
        private static MyContext context = new MyContext();

        public static List<Product> ReturnAllProducts()
        {
            return Queries.context.Product.ToList();
        }
    }
}
