using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class ProductPicture : TemplateModel
    {
        public int? id_Product { get; set; }

        public int? id_Picture { get; set; }
    }
}
