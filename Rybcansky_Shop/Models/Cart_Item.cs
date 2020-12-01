using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Cart_Item : TemplateModel
    {
        public int? id_Cart { get; set; }

        public int? id_Product_Variant { get; set; }

        public int quantity { get; set; }

        public string size { get; set; }
    }
}
