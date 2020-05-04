using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstMVC.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            List<SubjectModel> l = new List<SubjectModel>();





            //TEST bez DB
            //SubjectModel s = new SubjectModel { ID = 1, FirstName = "Michal", LastName = "Chamrád", SchoolClass = "C2a" };

            //l.Add(s);

            return View();
        }


        public IActionResult CreateNew()
        {
            return View();
        }

        [HttpPost] //viz. html form
        public void CreateNew(SubjectModel newSubject)
        {

            //List<SubjectModel> l = new List<SubjectModel>();

            //l.Add(newSubject);

            //return View("Index");

            //TODO: zapsání dat do db + NÁVRAT NA INDEX

        }

        /*
         todo:  
            1. zprovoznit EDIT(HTTPpUT)/delete/detail
            2. napojení na db 
            
            -- odevzdat na email --
         */



    }
}