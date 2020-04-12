using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Slovnik
{


    public partial class Form1 : Form
    {
        #region Proměnné

        /// <summary>
        /// connectionString pro připojení k databázi, načítaný z app.config
        /// </summary>
        string connectionString = ConfigurationManager.ConnectionStrings["Slovnik"].ConnectionString;

        /// <summary>
        /// Aktuálně překládaný jazyk (defaultně nastaveno z češtiny)
        /// </summary>
        Jazyk jazyk = Jazyk.cz;

        #endregion

        #region Konstruktor
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Buttons

        private void Translate_Click(object sender, EventArgs e)
        {

            //podmínka cz-en / en-cz
            if(jazyk != Jazyk.cz)
            {
                // Překlad z angličtny do češtiny
                TranslateENtoCZ();
            }

            if (jazyk != Jazyk.en)
            {
                // Překlad z češtiny do angličtiny
                TranslateCZtoEN();
            }
            
        }
        

        /// <summary>
        /// Změní aktuální pekládaný jazyk a popisky textBoxů
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LanguageChange_Click(object sender, EventArgs e)
        {

            // Z Češtiny na Angličtinu
            if (jazyk != Jazyk.en)
            {
                jazyk = Jazyk.en;
                LanguageIn.Text = "EN";
                LanguageOut.Text = "CZ";
            }
            // Z Angličtiny na Češtinu
            else
            {
                jazyk = Jazyk.cz;
                LanguageIn.Text = "CZ";
                LanguageOut.Text = "EN";
            }

            // Smazání txt polí
            this.TranslateIn.Text = string.Empty;
            this.TranslateOut.Text = string.Empty;

            //Kurzor v prvním poli
            this.TranslateIn.Focus();

        }

        /// <summary>
        /// Tlačítko pro otevření dialogu na zadávání nových slovních spojení
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VlozeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //vytvoření instance třídy Insert
            Insert vlozeni = new Insert();

            // Zobrazení okna
            vlozeni.Show();


        }

        #endregion

        #region Překládací metody

        /// <summary>
        /// K zadanému výrazu najde všechna odpovídající slova v druhém jazyce a vypíše je.
        /// </summary>
        private void TranslateCZtoEN()
        {
            try
            {
                using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
                {
                    // Dotaz se selectem
                    string select = "select en.slovo from dvojice inner join cz on dvojice.cz_id = cz.id inner join en on dvojice.en_id = en.id where cz.slovo = @czSlovo";

                    // Deklarace příkazu
                    SqlCommand prikaz = new SqlCommand(select, pripojeni);

                    // Uživatelský vstup (v malých písmenech)
                    string vstup = TranslateIn.Text.ToLower();

                    // Ošetření proti SQL Injection útoku
                    prikaz.Parameters.AddWithValue("@czSlovo", vstup);

                    // Otevření spojení
                    pripojeni.Open();

                    // Server status
                    serverStatus.Text = "Funkční";
                    serverStatus.ForeColor = Color.Green;

                    // Provedení příkazu
                    SqlDataReader dataReader = prikaz.ExecuteReader();

                    //pomocná proměnná pro výsledný překlad
                    string vysledek = string.Empty;

                    // Postupný výpis získaného výsledku z databáze
                    while (dataReader.Read())
                    {
                        vysledek += " " + (string)dataReader[0];
                    }

                    // Ošetření chybného zadání uživatele, pomocí regulárních výrazů
                    Regex jenPismena = new Regex("^[a-záčďéěíňóřšťůúýž]{1,30}$");
                    Match match = jenPismena.Match(vstup);
                    if (!match.Success)
                    {
                        throw new ArgumentException("Chybné zadaného vstupu", vstup);
                    }


                    //Absence překladu v databázi
                    if (vysledek.Equals(string.Empty))
                    {
                        throw new NullReferenceException("Překlad pro dané slovo neexistuje.");
                    }
                    else
                    {
                        // Reset barvy na černou
                        TranslateOut.ForeColor = Color.Black;
                        // Výpis výsledku
                        TranslateOut.Text = vysledek;
                    }

                }
            }
            // Chyba databáze
            catch(SqlException e)
            {
                serverStatus.Text = e.Message;
                serverStatus.ForeColor = Color.Red;
            }
            // Chyba žádného uživatelského zadání
            catch (ArgumentException e)
            {
                TranslateOut.Text = e.Message;
                TranslateOut.ForeColor = Color.Red;
            }
            // Absence překladu zadaného výrazu
            catch (NullReferenceException e)
            {
                TranslateOut.Text = e.Message;
                TranslateOut.ForeColor = Color.Red;
            }

        }

        /// <summary>
        /// K zadanému výrazu najde všechna odpovídající slova v druhém jazyce a vypíše je.
        /// </summary>
        private void TranslateENtoCZ()
        {

            try
            {
                using (SqlConnection pripojeni = new SqlConnection(connectionString)) //deklarace pripojení
                {
                    // Dotaz se selectem
                    string select = "select cz.slovo from dvojice inner join cz on dvojice.cz_id = cz.id inner join en on dvojice.en_id = en.id where en.slovo = @enSlovo";

                    // Deklarace příkazu
                    SqlCommand prikaz = new SqlCommand(select, pripojeni);

                    // Uživatelský vstup (v malých písmenech)
                    string vstup = TranslateIn.Text.ToLower();

                    // Ošetření proti SQL Injection útoku
                    prikaz.Parameters.AddWithValue("@enSlovo", vstup);

                    // Otevření spojení
                    pripojeni.Open();

                    // Server status
                    serverStatus.Text = "Funkční";
                    serverStatus.ForeColor = Color.Green;

                    // Provedení příkazu
                    SqlDataReader dataReader = prikaz.ExecuteReader();

                    //pomocná proměnná pro výsledný překlad
                    string vysledek = string.Empty;

                    // Postupný výpis získaného výsledku z databáze
                    while (dataReader.Read())
                    {
                        vysledek += " " + (string)dataReader[0];
                    }

                    // Ošetření chybného zadání uživatele, pomocí regulárních výrazů
                    Regex jenPismena = new Regex("^[a-z]{1,30}$");
                    Match match = jenPismena.Match(vstup);
                    if (!match.Success)
                    {
                        throw new ArgumentException("Vstup mohou být jen písmena", vstup);
                    }


                    //Absence překladu v databázi
                    if (vysledek.Equals(string.Empty))
                    {
                        throw new NullReferenceException("Překlad pro dané slovo neexistuje.");
                    }
                    else
                    {
                        // Reset barvy na černou
                        TranslateOut.ForeColor = Color.Black;
                        // Výpis výsledku
                        TranslateOut.Text = vysledek;
                    }


                }
            }
            // Chyba databáze
            catch (SqlException e)
            {
                serverStatus.Text = e.Message;
                serverStatus.ForeColor = Color.Red;
            }
            // Chybné  uživatelské zadání
            catch (ArgumentException e)
            {
                TranslateOut.Text = e.Message;
                TranslateOut.ForeColor = Color.Red;
            }
            // Absence překladu zadaného výrazu
            catch (NullReferenceException e)
            {
                TranslateOut.Text = e.Message;
                TranslateOut.ForeColor = Color.Red;
            }

        }

        #endregion

        #region clearButtons
        /// <summary>
        /// Smaže vstupní textové pole
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearInButton_Click(object sender, EventArgs e)
        {
            //nahradí text prázdným textovým řetězcem
            TranslateIn.Text = string.Empty;
            TranslateOut.Text = string.Empty;
        }

        /// <summary>
        /// Smaže výstupní textové pole
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearOutButton_Click(object sender, EventArgs e)
        {
            //nahradí text prázdným textovým řetězcem
            TranslateIn.Text = string.Empty;
            TranslateOut.Text = string.Empty;

        }








        #endregion


    }

}



