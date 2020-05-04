using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using firstMVC.Helpers;
using firstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;

namespace firstMVC.Controllers
{
    public class BasketController : Controller
    {

        #region DBSettings
        /// <summary>
        /// Konstruktor pro načtení ConnectionStringu z appSettings
        /// </summary>
        /// <param name="dbSettings"></param>
        public BasketController(IOptions<DBSettings> dbSettings)
        {
            _dbSettings = dbSettings.Value;
        }

        DBSettings _dbSettings; //field na urovni třídy
        
        public string Local
        {
            get { return _dbSettings.ConnectionStringLocal; }
        }
        public string PV
        {
            get { return _dbSettings.ConnectionStringPV; }
        }

        // ZDE SE NASTAVÍ POŽADOVANÁ DATABÁZE
        public string connectionString
        {
            get { return PV; }
        }
        #endregion

        #region INDEX
        /// <summary>
        /// Zobrazí košík
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //list položek nákupu
            List<BasketModel> basketList = new List<BasketModel>();

            using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
            {
                // Dotaz se selectem
                string select = "select PolozkaNakupu.id, p.nazev Produkt, pocet_ks Ks, p.cena Cena_ks from PolozkaNakupu inner join Produkt p on PolozkaNakupu.produkt_id = p.id where kosik_id = 1";

                // Deklarace příkazu
                SqlCommand prikaz = new SqlCommand(select, pripojeni);

                // Otevření spojení
                pripojeni.Open();

                // Provedení příkazu
                SqlDataReader dataReader = prikaz.ExecuteReader();

                // načtení jednotlivých položek košíku do Listu
                while (dataReader.Read())
                {
                    basketList.Add(new BasketModel()
                    {
                        ID = (int)dataReader[0],
                        Produkt = (string)dataReader[1],
                        Ks = (int)dataReader[2],
                        CenaKs = (int)dataReader[3]
                    });
                }
            }

            // nadpis stránky dle DB
            if(connectionString == PV)
            {
                ViewBag.title = "Databaze PV";
            }
            if (connectionString == Local)
            {
                ViewBag.title = "Databaze Local";
            }

            // Zobrazení košiku s načtenými daty
            return View(basketList);
        }
        #endregion

        #region ADD
        /// <summary>
        /// Zobrazí formulář pro vložení nového zboží
        /// </summary>
        /// <returns>stránku s formulářem na přidání zboží</returns>
        public IActionResult Add()
        {
            //TODO: 1. AJAX - LIVE ZOBRAZENÍ CENY/KS A CENY_CELKEM PŘI VOLBĚ V DRROPDOWN LISTU

            #region DROPDOWN LIST - produkty
            //dropDown produkty
            List<SelectListItem> produkty = new List<SelectListItem>();

            // Načtení hodnot do dropDown listu (+ ceny pro AJAX live zobrazení)
            using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
            {
                // Dotaz se selectem
                string select = "SELECT nazev,cena FROM Produkt;";
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
                    produkty.Add(new SelectListItem()
                    {
                        Value = (string)dataReader[0],
                    });
                }
            }
            //dropdown list 
            ViewBag.productList = produkty;
            #endregion

            // zobrazení view na přidání zboží
            return View();
        }

        /// <summary>
        /// Přidání nového zboží do košíku
        /// </summary>
        /// <param name="newItem"></param>
        /// <returns></returns>
        [HttpPost] //viz. nastavení v html form
        public ActionResult Add(BasketModel newItem)
        {
            //validace (?bůh ví co dělá?)
            if (!ModelState.IsValid)
            {
                return View(newItem);
            }

            //vložení nového itemu do košíku
            using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
            {
                // Dotaz se selectem
                string insert = "EXEC mp_pridej_produkt  1 ," + newItem.Produkt + ", " + newItem.Ks + ";";

                // Deklarace příkazu
                SqlCommand prikaz = new SqlCommand(insert, pripojeni);

                // Otevření spojení
                pripojeni.Open();

                // Provedení příkazu
                prikaz.ExecuteNonQuery();
            }

            // Návrat do košíku
            return Redirect("/Basket");
        }
        #endregion

        #region DELETE
        /// <summary>
        /// Otevře potvrzení zda skutečně chcete smazat
        /// </summary>
        /// <param name="id">id položky ke smazání</param>
        /// <returns></returns>
        public IActionResult Delete(int? id)
        {
            #region Ověření existence příchozího ID
            // chby: není-li id
            if (id == null)
            {
                return BadRequest();
            }
            #endregion

            #region Ověření existence záznamu v DB
            //ověření existence v db (NEFUNKČNÍ)
            using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
            {
                // Dotaz se selectem
                string select = "SELECT kosik_id FROM PolozkaNakupu where id =" + id;

                // Deklarace příkazu
                SqlCommand prikaz = new SqlCommand(select, pripojeni);

                // Otevření spojení
                pripojeni.Open();

                int? value = null;
                // !! PŘI ABSENCI ZÁZNAMU V DB, EXECUTESCALAR VYHODÍ VYJÍMKU, NE NULL !!
                value = (int)prikaz.ExecuteScalar();

                if (value == null)
                {
                    return NotFound();
                }

            }
            #endregion

            // pro přenos id zabaleno do BasketModelu (možná zbytečně překombinovaný)
            BasketModel item = new BasketModel() { ID = (int)id };

            return View(item);
        }

        /// <summary>
        /// Smaže záznam v DB, dle zadané ID
        /// </summary>
        /// <param name="item">BasketModel s id položky ke smazání</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Delete(BasketModel item)
        {
            using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
            {
                // Dotaz se selectem
                string select = "DELETE FROM PolozkaNakupu WHERE id =" + item.ID;

                // Deklarace příkazu
                SqlCommand prikaz = new SqlCommand(select, pripojeni);

                // Otevření spojení
                pripojeni.Open();

                // Provedení příkazu
                prikaz.ExecuteNonQuery();

            }
            // návrat do košíku
            return Redirect("/Basket");
        }
        #endregion

        #region EDIT
        /// <summary>
        /// Otevře view pro Edit
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit()
        {
            //TODO: 1. vypsání detailů o editovaném zboží v pohledu
            //      2. AJAX - live náhled celkové ceny již při psaní počtu kusů

            return View();
        }

        /// <summary>
        /// Mění počet kusů daného zboží v košíku
        /// </summary>
        /// <param name="item">BasketModel pro přenos zadaných dat</param>
        /// <returns></returns>
        [HttpPost] //viz. nastavení v html form
        public ActionResult Edit(BasketModel item)
        {
            //změna počtu v db
            using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
            {
                // Dotaz se selectem
                string update = "UPDATE PolozkaNakupu SET pocet_ks = "+item.Ks+" WHERE id ="+item.ID;

                // Deklarace příkazu
                SqlCommand prikaz = new SqlCommand(update, pripojeni);

                // Otevření spojení
                pripojeni.Open();

               prikaz.ExecuteNonQuery();

            }

            return Redirect("/Basket");
        }
        #endregion

    }

}