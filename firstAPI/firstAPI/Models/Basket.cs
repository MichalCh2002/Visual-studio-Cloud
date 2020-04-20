using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstAPI.Models
{
    public class Basket
    {
        public int ID { get; set; }
        public string Produkt { get; set; }
        public int Ks { get; set; }
        public int CenaKs { get; set; }
        public int CenaCelkem{
            get
            {
                return CenaKs * Ks;
            }
        }
    }
}
