using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Article_Tag : TemplateModel
    {
        public int? id_Article { get; set; }

        public int? id_Tag { get; set; }
    }
}
