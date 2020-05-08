using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace firstMVC.Models
{
    public class BasketModel
    {
        [Display(Name = "ID")]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Název Produktu")]
        public string Produkt { get; set; }
        [Required]
        [Display(Name = "Počet ks")]
        public int Ks { get; set; }
        [Display(Name = "Cena/ks")]
        public int CenaKs { get; set; }
        [Display(Name = "Cena")]
        public int CenaCelkem
        {
            get
            {
                return CenaKs * Ks;
            }
        }
    }
}
