using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.Web.Carts
{
    public class CartClass
    {
        public int id { get; set; }

        public int quantity { get; set; }

        public string picture { get; set; }

        public string ProductName { get; set; }

        public string VariantName { get; set; }

        public decimal? variantPriceStandart { get; set; }

        public decimal? variantPriceDiscount { get; set; }
    }
}
