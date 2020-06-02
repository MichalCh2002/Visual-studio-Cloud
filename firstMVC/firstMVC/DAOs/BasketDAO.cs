using firstMVC.Helpers;
using firstMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace firstMVC.DAOs
{
    /// <summary>
    /// Práce s daty u nákupního košíku
    /// </summary>
    public class BasketDAO
    {
        #region DBSettings
        //DBSettings
        DBSettings _dbSettings; //field na urovni třídy
        public BasketDAO(IOptions<DBSettings> dbSettings)
        {
            _dbSettings = dbSettings.Value;
        }

        public string Local
        {
            get { return _dbSettings.ConnectionStrings["Local"]; }
        }
        public string PV
        {
            get { return _dbSettings.ConnectionStrings["PV"]; }
        }

        // ZDE SE NASTAVÍ POŽADOVANÁ DATABÁZE
        public string connectionString
        {
            get { return PV; }
        }

        /// <summary>
        /// vrací právě použitou db
        /// </summary>
        /// <returns></returns>
        public string DBType()
        {
            if (connectionString == PV)
            {
                return "Databaze PV";
            }
            if (connectionString == Local)
            {
                return "Databaze Local";
            }
            return "neznámá DB";
        }


        #endregion

        
        #region SELECTs

        /// <summary>
        /// SELECT VŠECH PRODUKTŮ V KOŠÍKU DLE ID KOŠÍKU
        /// </summary>
        /// <param name="basketID">ID požadovaného košíku</param>
        /// <returns>List položek v košíku</returns>
        public List<BasketModel> AllProductsInBasket(int basketID)
        {
            //list položek nákupu
            List<BasketModel> basketList = new List<BasketModel>();

            using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
            {
                // Dotaz se selectem
                string select = "select PolozkaNakupu.id, p.nazev Produkt, pocet_ks Ks, p.cena Cena_ks from PolozkaNakupu inner join Produkt p on PolozkaNakupu.produkt_id = p.id where kosik_id =" + basketID;

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
            return basketList;
        }

        //selct informac9 o jedn0 polo6kz dle id => Basketmodel poloyka

        /// <summary>
        /// vypíše všechny informace o dané položce dle id
        /// </summary>
        /// <param name="polozkaID">id požadované položky</param>
        /// <returns>informace o položce</returns>
        public BasketModel SelectItem(int polozkaID)
        {
            BasketModel item = new BasketModel();

            using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
            {
                // Dotaz se selectem
                string select = "select PolozkaNakupu.id, p.nazev Produkt, pocet_ks Ks, p.cena Cena_ks from PolozkaNakupu inner join Produkt p on PolozkaNakupu.produkt_id = p.id where PolozkaNakupu.id =" + polozkaID;

                // Deklarace příkazu
                SqlCommand prikaz = new SqlCommand(select, pripojeni);

                // Otevření spojení
                pripojeni.Open();

                // Provedení příkazu
                SqlDataReader dataReader = prikaz.ExecuteReader();

                // načtení jednotlivých položek košíku do Listu
                while (dataReader.Read())
                {
                    item.ID = (int)dataReader["id"];
                    item.Produkt = (string)dataReader[1];
                    item.Ks = (int)dataReader[2];
                    item.CenaKs = (int)dataReader[3];
                }
            }
            return item;
        }

        /// <summary>
        /// SELECT VŠECH NÁZVŮ EXISTUJÍCÍHO ZBOŽÍ
        /// </summary>
        /// <returns>List select list itemů</returns>
        public List<SelectListItem> AllProductTypes()
        {
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
            return produkty;
        }

        //SELECT KOSIK_ID ZBOŽÍ DLE ID => TRUE/FALSE [EXISTENCE V DB]
        /// <summary>
        /// Ověří existenci polozky v db
        /// </summary>
        /// <param name="plozkaID">ID poloky v db</param>
        /// <returns></returns>
        public bool ExistProduct(int polozkaID)
        {
            //ověření existence v db (NEFUNKČNÍ)
            using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
            {
                // Dotaz se selectem
                string select = "SELECT kosik_id FROM PolozkaNakupu where id =" + polozkaID;

                // Deklarace příkazu
                SqlCommand prikaz = new SqlCommand(select, pripojeni);

                // Otevření spojení
                pripojeni.Open();

                // !! PŘI ABSENCI ZÁZNAMU V DB, EXECUTESCALAR VYHODÍ VYJÍMKU, NE NULL !!
                try
                {
                    prikaz.ExecuteScalar();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        #endregion

        #region INSERTs

        /// <summary>
        /// Vloží existující zboží do košíku
        /// </summary>
        /// <param name="product">Parametry vkládaného zboží</param>
        public void AddProduct(BasketModel product)
        {
            //!!! Kontrola vyjímek zde (chyba serveru) !!!

            // Vložení nového itemu do košíku
            using (SqlConnection pripojeni = new SqlConnection(connectionString)) // Deklarace pripojení
            {
                // Dotaz se selectem
                SqlCommand insert = new SqlCommand("mp_pridej_produkt @Kosik_id, @Product, @Pocet_ks ", pripojeni);
                insert.Parameters.AddWithValue("@Kosik_id", 1);
                insert.Parameters.AddWithValue("@Product", product.Produkt);
                insert.Parameters.AddWithValue("@Pocet_ks", product.Ks);
                //insert.Parameters.Add("@newID", SqlDbType.Int, 0).Direction = ParameterDirection.Output; // Pro výstupní parametr procedury

                // Otevření spojení
                pripojeni.Open();

                // Provedení příkazu
                insert.ExecuteNonQuery();
            }
        }

        #endregion

        #region DELETEs
        //DELETE POLOZKYKOSIKU DLE ID => TRUE/FALSE [ÚSPĚŠNOST PROVEDENÍ]

        /// <summary>
        /// Smaže plozku dle id
        /// </summary>
        /// <param name="polozkaID">ID polzky ke smazání</param>
        /// <returns>vrátí uspěšnost provedení</returns>
        public bool DeleteItem(int polozkaID)
        {
            using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
            {
                // Dotaz se selectem
                string select = "DELETE FROM PolozkaNakupu WHERE id =" + polozkaID;

                // Deklarace příkazu
                SqlCommand prikaz = new SqlCommand(select, pripojeni);

                // Otevření spojení
                pripojeni.Open();


                // Provedení příkazu
                if (prikaz.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        #endregion

        #region UPDATEs

        /// <summary>
        /// změní počet ks dané položky v košíku
        /// </summary>
        /// <param name="polozkaID">id polozky ke změně počtu</param>
        /// <param name="newCount">nový počet ks</param>
        /// <returns>úspěšnost provedení</returns>
        public bool EditCount(int polozkaID, int newCount)
        {
            //změna počtu v db
            using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
            {
                // Dotaz se selectem
                string update = "UPDATE PolozkaNakupu SET pocet_ks = " + newCount+ " WHERE id =" + polozkaID;

                // Deklarace příkazu
                SqlCommand prikaz = new SqlCommand(update, pripojeni);

                // Otevření spojení
                pripojeni.Open();

                if (prikaz.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }

        #endregion
    }
}
