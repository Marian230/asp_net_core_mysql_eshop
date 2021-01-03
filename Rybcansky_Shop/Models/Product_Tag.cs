using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Product_Tag : TemplateModel
    {
        public int? id_Product { get; set; }

        public int? id_Tag { get; set; }
    }
}
