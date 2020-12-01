using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Payment_Methods : TemplateModel
    {
        [DisplayName("Název")]
        public string method { get; set; }
    }
}
