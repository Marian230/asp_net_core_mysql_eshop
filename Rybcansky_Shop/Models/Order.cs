using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Order : TemplateModel
    {
        public DateTime time { get; set; }

        public bool finished { get; set; }

        public int? cookie_Id { get; set; }

        public decimal? price_Standart { get; set; }

        public decimal? price_Discount { get; set; }

        public DateTime last_Acces_Time { get; set; }

        public int? id_Contact_Info { get; set; }

        public int? id_Shipping_Method { get; set; }

        public int? id_Payment_Methods { get; set; }

        public int? id_Primary_Billing_Adress { get; set; }

        public int? id_Different_Billing_Adress { get; set; }
    }
}
