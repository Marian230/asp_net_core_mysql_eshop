using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Message : TemplateModel
    {
        public string full_Name { get; set; }

        public string subject { get; set; }

        public string message { get; set; }
    }
}
