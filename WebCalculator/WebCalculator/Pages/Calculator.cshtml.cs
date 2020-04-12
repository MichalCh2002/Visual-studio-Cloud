using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebCalculator.Pages
{
    public class CalculatorModel : PageModel
    {


        #region Proměnné

        [BindProperty()] // propojení s html
        public double Cislo1 { get; set; }

        [BindProperty()] // propojení s html
        public double Cislo2 { get; set; }

        [BindProperty()] // propojení s html
        public string Vysledek { get; set; }

        [BindProperty]
        public char Znamenko { get; set; } // znamenko do rovnice
        #endregion

        /// <summary>
        /// Zavolána při spuštění stránky
        /// </summary>
        public void OnGet()
        {
            Znamenko = '+';
        }

        public ActionResult OnPost()
        {
            
            VypocitejDleZnamenka(Znamenko);


            //překreslí stránku
            return Page();
        }

        /// <summary>
        /// Nastaví výsledek na dle výpočtu pomocí zadaného znaménka
        /// </summary>
        /// <param name="znamenko"></param>
        private void VypocitejDleZnamenka(char znamenko)
        {

            if (znamenko.Equals('+')){
                double v = Cislo1 + Cislo2;
                Vysledek = v.ToString();
            }

            if (znamenko.Equals('-'))
            {
                double v = Cislo1 - Cislo2;
                Vysledek = v.ToString();
            }

            if (znamenko.Equals('*'))
            {
                double v = Cislo1 * Cislo2;
                Vysledek = v.ToString();
            }

            if (znamenko.Equals('/'))
            {
                if (Cislo2 != 0)
                {
                    double v = Cislo1 / Cislo2;
                    Vysledek = v.ToString();
                }
                else
                {
                    Vysledek = "nelze dělit nulou";
                }


                
            }

        }





    }
}