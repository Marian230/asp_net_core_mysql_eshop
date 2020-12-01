using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Shipping_Method : TemplateModel
    {
        [DisplayName("Způsob")]
        public string method { get; set; }
    }
}
