using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Comment : TemplateModel
    {
        [ForeignKey("id")]
        public int? id_Article { get; set; }

        public string text { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public DateTime time { get; set; }
    }
}
