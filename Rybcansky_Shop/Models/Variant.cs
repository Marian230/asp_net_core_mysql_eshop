using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Variant : TemplateModel
    {
        public int? id_Size { get; set; }

        public int id_Product { get; set; }

        public int? size { get; set; }

        [DisplayName("Varianta")]
        public string color { get; set; }

        public int? number { get; set; }

        public int? stock_Number { get; set; }

        public decimal? price_Standart { get; set; }

        public decimal? price_Discount { get; set; }
    }
}
