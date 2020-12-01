using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Category : TemplateModel
    {
        [DisplayName("Název")]
        public string name { get; set; }

        [DisplayName("Popis")]
        public string description { get; set; }
    }
}
