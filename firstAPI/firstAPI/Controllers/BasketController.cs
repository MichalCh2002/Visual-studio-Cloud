using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using firstAPI.Helpers;
using firstAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace firstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        /// <summary>
        /// Konstruktor pro načtení ConnectionStringu z appSettings
        /// </summary>
        /// <param name="dbSettings"></param>
        public BasketController(IOptions<DBSettings> dbSettings)
        {
            _dbSettings = dbSettings.Value;
        }

        DBSettings _dbSettings; //field na urovni třídy _

            


        /// <summary>
        /// Vrací Položky v nákupním košíku daného id
        /// </summary>
        /// <param name="id">ID nákupního košíku</param>
        /// <returns>Položky v nákupním košíku</returns>
        // GET: api/Basket/id
        [HttpGet("{BasketId}")]
        public IEnumerable<Basket> Get(int BasketId)
        {
            // list se všemi produkty v košíku
            List<Basket> result = new List<Basket>();

            //načtení položek z db do Listu
            using (SqlConnection pripojeni = new SqlConnection(_dbSettings.ConnectionStringLocal)) //deklarace pripojení
            {
                // Dotaz se selectem
                string select = "select p.nazev Produkt, pocet_ks Ks, p.cena Cena_ks from PolozkaNakupu inner join Produkt p on PolozkaNakupu.produkt_id = p.id where kosik_id = " + BasketId;

                // Deklarace příkazu
                SqlCommand prikaz = new SqlCommand(select, pripojeni);

                // Otevření spojení
                pripojeni.Open();

                // Provedení příkazu
                SqlDataReader dataReader = prikaz.ExecuteReader();

                int i = 0;
                while (dataReader.Read())
                {
                    i++;
                    result.Add(new Basket()
                    {
                        ID = i,
                        Produkt = (string)dataReader[0],
                        Ks = (int)dataReader[1],
                        CenaKs = (int)dataReader[2]
                    });
                }
            }

           return result;
        }
                
            
        

        // POST: api/Basket
        [HttpPost("{BasketId}/{Produkt}/{Ks}")]
        public void Post(int BasketId, string Produkt, int Ks)
        {
            using (SqlConnection pripojeni = new SqlConnection(_dbSettings.ConnectionStringLocal)) //deklarace pripojení
            {
                // Dotaz se selectem
                string insert = "EXEC mp_pridej_produkt " + BasketId + " ,'"+Produkt+"', "+Ks+";";

                // Deklarace příkazu
                SqlCommand prikaz = new SqlCommand(insert, pripojeni);

                // Otevření spojení
                pripojeni.Open();

                // Provedení příkazu
                prikaz.ExecuteNonQuery();
            }
        }

        // PUT: api/Basket/5
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
