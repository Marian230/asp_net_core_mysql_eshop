using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Order_Item : TemplateModel
    {
        public int? id_Order { get; set; }

        public int? id_Product { get; set; }

        public decimal? price_Standart { get; set; }

        public decimal? price_Discount { get; set; }

        public int quantity { get; set; }

        public string size { get; set; }
    }
}
