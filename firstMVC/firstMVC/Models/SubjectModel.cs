
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace firstMVC.Models
{
    public class SubjectModel
    {
        [Display(Name = "ID")]  //argument pro konečné zobrazení jména
        public Int32 ID { get; set; }
        [Display(Name ="Jméno")]
        public string FirstName{ get; set; }
        [Display(Name = "Příjmení")]
        public string LastName{ get; set; }
        [Display(Name = "Třída")]
       // [RegularExpression("[]")]  // Validace vstupu dat
        public string SchoolClass{ get; set; }
        

    }
}
