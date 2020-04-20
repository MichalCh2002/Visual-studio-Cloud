using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace firstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        // GET: api/Subject
        [HttpGet]
        public IEnumerable<Subject> Get()
        {
            List<Subject> result = new List<Subject>();

            //načtení z db

            //všechny, jeden konkrétní, zápis

            result.Add(new Subject() { ID = 4, FirstName = "Michal", LastName = "Novák" });
            result.Add(new Subject() { ID = 4, FirstName = "Pavel", LastName = "Klus" });


            return result;
        }

        // GET: api/Subject/5
        // GET: api/Subject/5/true
        [HttpGet("{id}")]
        [HttpGet("{id}/{suspend}")]
        public Subject Get(int id, Boolean? suspend)
        {
            Subject result;

            //načtení z db

            result=new Subject { ID = id, FirstName = "Michal", LastName = "Novák" };
            return result;
        }


        // posílání
        // POST: api/Subject
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return new OkResult(); //insert update (delete) 
            // chyby http status code result 
        }

        // PUT: api/Subject/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
