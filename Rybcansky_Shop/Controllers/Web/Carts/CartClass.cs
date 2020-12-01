using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.Web.Carts
{
    public class CartClass
    {
        public int id { get; set; }

        public string productName { get; set; }

        public string productVariantName { get; set; }

        public int number { get; set; }
    }
}
