using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Article : TemplateModel
    {
        [DisplayName("Autor")]
        [Required]
        public string author { get; set; }
        
        [DisplayName("Nadpis")]
        [Required]
        public string header { get; set; }

        
        [DisplayName("Článek")]
        [Required]
        public string text { get; set; }

        
        [DisplayName("Čas")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [Required]
        public DateTime time { get; set; }
        
        [DisplayName("Obrázky")]
        public int? id_Picture { get; set; }
    }
}
