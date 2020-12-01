using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Contact_Info : TemplateModel
    {
        public string email { get; set; }

        public string first_Name { get; set; }

        public string last_Name { get; set; }

        public bool subscribe_Newsletter { get; set; }

        public bool save_Information { get; set; }

        public bool use_Different_Billing_Address { get; set; }
    }
}
