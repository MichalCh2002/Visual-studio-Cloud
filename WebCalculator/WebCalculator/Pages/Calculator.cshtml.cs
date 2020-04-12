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

        [Display(Name = "Číslo 1")]
        [BindProperty()] // propojení s html
        public Int32 Cislo1 { get; set; }

        [Display(Name = "Číslo 2")]
        [BindProperty()] // propojení s html
        public Int32 Cislo2 { get; set; }

        [BindProperty()] // propojení s html
        public Int32 Vysledek { get; set; }
        #endregion

        /// <summary>
        /// Zavolána při spuštění stránky
        /// </summary>
        public void OnGet()
        {

        }

        public ActionResult OnPost()
        {
            //výpočet
            Vysledek = Cislo1 * Cislo2;

            //překreslí stránku
            return Page();
        }

        /*
        TODO: 

            Možnost zvolit operaci výpočtu.
        
         */



    }
}