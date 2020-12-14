using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Billing_Adress : TemplateModel
    {
        public string address { get; set; }

        public string appartmant { get; set; }

        public string city { get; set; }

        public string country { get; set; }

        public string postal_Code { get; set; }
    }
}