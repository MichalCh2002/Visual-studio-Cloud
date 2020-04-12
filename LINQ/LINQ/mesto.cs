using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class mesto
    {

        private string nazev;
        private int pocetObyvatel;

        public mesto(string nazev, int pocetObyvatel)
        {
            this.Nazev = nazev;
            this.PocetObyvatel = pocetObyvatel;
        }

        public string Nazev { get => nazev; set => nazev = value; }
        public int PocetObyvatel { get => pocetObyvatel; set => pocetObyvatel = value; }

        public override string ToString()
        {
            return Nazev + " [" + PocetObyvatel + "]";
        }
    }
}
