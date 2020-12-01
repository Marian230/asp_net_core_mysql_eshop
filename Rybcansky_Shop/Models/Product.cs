using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rybcansky_Shop.Models
{
    public class Product : TemplateModel
    {
        [DisplayName("Název")]
        public string name { get; set; }

        [DisplayName("Standartní cena")]
        public double? price_Standart { get; set; }

        [DisplayName("Slevněná cena")]
        public double? price_Discount { get; set; }

        [DisplayName("DPH")]
        public int vat_rate { get; set; }

        [DisplayName("Popis")]
        public string description { get; set; }

        [DisplayName("Čas přidání")]
        public DateTime time { get; set; }

        [DisplayName("Počet variant")]
        public int variant_Number { get; set; }

        [DisplayName("Počet kusů na skladě")]
        public int stock_Number { get; set; }

        [DisplayName("Počet obrázku")]
        public int Number_Of_Picture { get; set; }

        [DisplayName("Kategorie")]
        public int? id_Category { get; set; }

        [DisplayName("Prodejce")]
        public int? id_Vendor { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}