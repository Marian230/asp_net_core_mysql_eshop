using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Picture : TemplateModel
    {
        public int? order { get; set; }

        public string name { get; set; }

        public string path { get; set; }
    }
}
