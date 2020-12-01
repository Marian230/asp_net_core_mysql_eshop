using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Controllers.ModelController.Product
{
    public class VariantClass
    {
        public string color { get; set; }

        public decimal? price_Standart { get; set; }

        public decimal? price_Discount { get; set; }

        public int? stock_Number { get; set; }
    }
}
