using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slovnik
{
    public partial class Insert : Form
    {
  

        #region Konstruktor

        public Insert()
        {
            InitializeComponent();
        }




        #endregion

        #region Proměnné

        /// <summary>
        /// connectionString pro připojení k databázi, načítaný z app.config
        /// </summary>
        string connectionString = ConfigurationManager.ConnectionStrings["Slovnik"].ConnectionString;

        /// <summary>
        /// Zadané české slovo 
        /// </summary>
        private string CZslovo { get; set; }
        
        /// <summary>
        /// Zadané anglické slovo 
        /// </summary>
        private string ENslovo { get; set; }

        /// <summary>
        /// Získané id českého slova
        /// </summary>
        private int CZ_ID { get; set; }

        /// <summary>
        /// Získané id anglického slova
        /// </summary>
        private int EN_ID { get; set; }

        
        #endregion

        #region Tlacitko Pridat

        /// <summary>
        /// Přidá nové slovní spojení, popřípadě oznámí že již existuje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {

            //smazání proměnných
            CZslovo = string.Empty;
            ENslovo = string.Empty;
            CZ_ID = 0;
            EN_ID = 0;

            //smazání logu
            labelLogOut.Text = string.Empty;


            try
            {
                // Uloží cz slovo nebo, pokud existuje, jeho id
                Cz();

                // Uloží en slovo nebo, pokud existuje, jeho id
                En();

                // Vloží novou dvojici, nebo oznámí, že již existuje
                Dvojice();

            }
        
            // Chybné uživatelské zadání
            catch (ArgumentException erf)
            {
                labelLogOut.Text += "\n" + erf.Message;
                labelLogOut.ForeColor = Color.Red;
            }
            // Již obsaženo v DB
            catch (Exception fdr)
            {
                labelLogOut.Text += "\n" + fdr.Message;
                labelLogOut.ForeColor = Color.Red;
            }

            // Smazání vstupních polí
            textBoxCZ.Text = string.Empty;
            textBoxEN.Text = string.Empty;

            //Kurzor v prvním poli
            this.textBoxCZ.Focus();
        }

        #endregion

        #region Hlavní Metody

        /// <summary>
        /// Zjistí existenci CZ slova. 
        ///     1a.(neexistuje) Uloží pro pozdější insert a získání id.
        ///     1b.(existuje) Získá jeho id.
        /// </summary>
        private void Cz()
        {
                // EN slovo od uživatele (v malých písmenech)
                CZslovo = textBoxCZ.Text.ToLower();


                // Ošetření chybného zadání uživatele, pomocí regulárních výrazů
                Regex jenPismena = new Regex("^[a-záčďéěíňóřšťůúýž]{1,30}$");
                Match match = jenPismena.Match(CZslovo);
                if (!match.Success)
                {
                    throw new ArgumentException("cz: Chybné zadání", CZslovo);
                }

                // Není-li v DB dané slovo
                if (!SlovoJeVDB("cz", CZslovo))
                {

                    //výpis slova
                    labelLogOut.ForeColor = Color.Black;
                    labelLogOut.Text += "\n CZ slovo nenalezeno, uloženo: " + CZslovo;

                }
                // Je-li v DB dané slovo
                else
                {
                    // Získání id slova z DB
                    int id = GetId("cz", CZslovo);

                    //výpis id
                    labelLogOut.ForeColor = Color.Black;
                    labelLogOut.Text += "\n CZ slovo nalezeno, uloženo cz_id: " + id;

                    //uložení id
                    CZ_ID = id;
                }


        }


        /// <summary>
        /// Zjistí existenci EN slova. 
        ///     1a.(neexistuje) Uloží pro pozdější insert a získání id.
        ///     1b.(existuje) Získá jeho id.
        /// </summary>
        private void En()
        {

            // EN slovo od uživatele (v malých písmenech)
            ENslovo = textBoxEN.Text.ToLower();


            // Ošetření chybného zadání uživatele, pomocí regulárních výrazů
            Regex jenPismena = new Regex("^[a-z]{1,30}$");
                Match match = jenPismena.Match(ENslovo);
                if (!match.Success)
                {
                    throw new ArgumentException("en: Chybné zadání", ENslovo);
                }

                // Není-li v DB dané slovo
                if (!SlovoJeVDB("en", ENslovo))
                {

                    //výpis slova
                    labelLogOut.ForeColor = Color.Black;
                    labelLogOut.Text += "\n EN slovo nenalezeno, uloženo: " + ENslovo;

                }
                // Je-li v DB dané slovo
                else
                {
                    // Získání id slova z DB
                    int id = GetId("en", ENslovo);

                    //výpis id
                    labelLogOut.ForeColor = Color.Black;
                    labelLogOut.Text += "\n EN slovo nalezeno, uloženo en_id: " + id;

                    //uložení id
                    EN_ID = id;
                }

        }


        /// <summary>
        /// Zjistí existenci dvojice slov:
        /// 
        ///     1a.(existuje) Vyhodí vyjímku, že již existuje.
        ///     
        ///     1b.(neexistuje) 
        ///         a) Vloží uložená slova do DB a získá jejich IDs.
        ///         b) Vloží novou dvojici(cz_id, en_id).
        ///         
        ///     
        /// </summary>
        private void Dvojice()
        {
            // Dvojice se v DB nachází
            if (DvojiceJeVDB(CZ_ID, EN_ID))
            {
                throw new Exception("Toto spojení se již v DB nachází");
            }

            // Dvojice se v DB nenachází
            if (!DvojiceJeVDB(CZ_ID, EN_ID))
            {
                if (CZ_ID == 0)
                {
                    // Vloží zadaný výraz do DB
                    InsertSlovo("cz", CZslovo);

                    // Získá ID vloženého slova
                    CZ_ID = GetId("cz", CZslovo);
                }

                if (EN_ID == 0)
                {
                    // Vloží zadaný výraz do DB
                    InsertSlovo("en", ENslovo);

                    // Získá ID vloženého slova
                    EN_ID = GetId("en", ENslovo);
                }

                // Vloží danou dvojici do DB
                InsertDvojice(CZ_ID, EN_ID);

                //Oznámení o Vložení 
                labelLogOut.Text += "\n ÚSPĚŠNĚ VLOŽENO: "+CZslovo+", "+ENslovo;
                labelLogOut.ForeColor = Color.Green;

            }

        }



        #endregion

        #region SQL Metody

            #region GET

                /// <summary>
                /// Vrací id daného slova z dané tabulky databáze
                /// </summary>
                /// <param name="tabulka"> Nazev zdrojové tabulky </param>
                /// <param name="slovo"> Slovo jehož chceme ID </param>
                /// <returns> Získané ID slova </returns>
                private int GetId(string tabulka ,string slovo)
                {
                    using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
                    {
                        // SQL select existueje=1 / neexistuje=0
                        string select = "select id from " + tabulka + " where slovo = @slovo; ";

                        // Deklarace příkazu
                        SqlCommand prikaz = new SqlCommand(select, pripojeni);

                        // Ošetření proti SQL Injection útoku (nepropustí SQL příkazy např.!! drop table !!)
                        prikaz.Parameters.AddWithValue("@slovo", slovo);

                        // Otevření spojení
                        pripojeni.Open();

                        // Provedení příkazu ( => Vrací id daného slova)
                        return (int)prikaz.ExecuteScalar();
                    }
                }

            #endregion

            #region INSERT
                /// <summary>
                /// Vloží do zadané tabulky, zadané slovo
                /// </summary>
                /// <param name="tabulka"> Název cílové tabulky </param>
                /// <param name="slovo"> Slovo pro vložení </param>
                private void InsertSlovo(string tabulka, string slovo)
                {
                    using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
                    {
                        // SQL select existueje=1 / neexistuje=0
                        string insert = "insert into "+tabulka+"(slovo) values(@slovo)";

                        // Deklarace příkazu
                        SqlCommand prikaz = new SqlCommand(insert, pripojeni);

                        // Ošetření proti SQL Injection útoku (nepropustí SQL příkazy např.!! drop table !!)
                        prikaz.Parameters.AddWithValue("@slovo", slovo);

                        // Otevření spojení
                        pripojeni.Open();

                        // Provedení příkazu ( => Vrací počet ovlivněných řádků, nevyužívám)
                        prikaz.ExecuteNonQuery();
                    }
                }

                /// <summary>
                /// Vloží do tabulky dvojic, zadanou dvojici slov
                /// </summary>
                /// <param name="CZid"> ID českého slova </param>
                /// <param name="ENid"> ID anglického slova </param>
                private void InsertDvojice(int CZid, int ENid)
                {
                    using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
                    {
                        // SQL select existueje=1 / neexistuje=0
                        string insert = "insert into dvojice(cz_id, en_id) values("+CZid+", "+ENid+")";

                        // Deklarace příkazu
                        SqlCommand prikaz = new SqlCommand(insert, pripojeni);

                        // Otevření spojení
                        pripojeni.Open();

                        // Provedení příkazu ( => Vrací počet ovlivněných řádků, nevyužívám)
                        prikaz.ExecuteNonQuery();
                    }
                }

            #endregion

            #region CONTAINS

                /// <summary>
                /// Ověřuje existenci slova v dané tabulce v DB.
                /// </summary>
                /// <param name="tabulka"> Tabulka kde existenci ověřujeme </param>
                /// <param name="slovo"> Slovo, jehož existenci chceme ověřit </param>
                /// <returns> Vrací jestli tabulka dané slovo obsahuje </returns>
                private bool SlovoJeVDB(string tabulka, string slovo)
                        {
                            using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
                            {
                                // SQL select existueje=1 / neexistuje=0
                                string select = "SELECT COUNT(1) FROM "+tabulka+ " WHERE slovo = @slovo ";

                                // Deklarace příkazu
                                SqlCommand prikaz = new SqlCommand(select, pripojeni);

                                // Ošetření proti SQL Injection útoku (nepropustí SQL příkazy např.!! drop table !!)
                                prikaz.Parameters.AddWithValue("@slovo", slovo);

                                // Otevření spojení
                                pripojeni.Open();

                                // Provedení příkazu => Vrací počet slov (1/0)
                                int pocet = (int)prikaz.ExecuteScalar();

                                // Dle počtu slov se nastaví zda slovo v DB je / není
                                if (pocet == 1)
                                {
                                    return true;
                                }
                                else
                                    return false;
                            }
                        }

                /// <summary>
                /// Ověřuje existenci dvojice v DB, popřípadě vyhazuje vyjímku
                /// </summary>
                /// <param name="CZ_ID"> ID záznamu českého slova v DB </param>
                /// <param name="EN_ID"> ID záznamu anglického slova v DB </param>
                /// <returns></returns>
                private bool DvojiceJeVDB(int CZid, int ENid)
                {
                    // Pokud jsme nezískali hned obě id, slovo v DB není, protože tam nejsou ani ta slova
                    if ((CZid == 0 && ENid == 0))
                    {
                        return false;
                    }

                    using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
                    {
                        // SQL select existueje=1 / neexistuje=0
                        string select = "SELECT COUNT(1) FROM dvojice WHERE cz_id = "+ CZid + " AND en_id = "+ ENid;

                        // Deklarace příkazu
                        SqlCommand prikaz = new SqlCommand(select, pripojeni);

                        // Otevření spojení
                        pripojeni.Open();

                        // Provedení příkazu => Vrací počet dvojic (1/0)
                        int pocet = (int)prikaz.ExecuteScalar();

                        // Dle počtu slov se nastaví zda slovo v DB je / není
                        if (pocet == 1)
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                }

            #endregion

        #endregion




    }
}
