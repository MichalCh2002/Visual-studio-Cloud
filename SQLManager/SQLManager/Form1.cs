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

namespace SQLManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            TextBoxOut.Text = string.Empty;

            using (SqlConnection pripojeni = new SqlConnection("Data Source=DESKTOP-NPVKUV6;Initial Catalog=Slovnik;Integrated Security=True")) //deklarace pripojení
            {
                try
                {
                    // Deklarace příkazu
                    SqlCommand prikaz = new SqlCommand(TextBoxIn.Text, pripojeni);

                    // Otevření spojení
                    pripojeni.Open();

                    // Provedení příkazu
                    SqlDataReader dataReader = prikaz.ExecuteReader();

                    //pomocná proměnná pro výsledný překlad
                    string vysledek = string.Empty;

                    // Postupný výpis získaného výsledku z databáze
                    while (dataReader.Read())
                    {
                        vysledek += " " + dataReader[0].ToString();
                    }

                    // Provedení příkazu 
                    TextBoxOut.Text = vysledek;
                }
                catch(SqlException eret)
                {
                    TextBoxOut.Text += eret.Message;
                }


            }
        }
    }
}
