using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Admin : TemplateModel
    {
        public string username { get; set; }

        public string password { get; set; }
    }
}
