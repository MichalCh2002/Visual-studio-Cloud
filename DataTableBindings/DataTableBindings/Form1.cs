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

namespace DataTableBindings
{
    public partial class Form1 : Form
    {

        public BindingSource zdrojdat;
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            //Připojení k serveru
            SqlConnection connection = new SqlConnection(@"Data Source=10.10.1.12;Database=pv;user id=student;password=StudentPV");
            connection.Open();

            //Příkaz
            SqlCommand command = new SqlCommand("Select * from sbj_subject;");
            command.Connection = connection;

            //Vytvořím lokální kopii tabulky
            DataTable lokalniTabulka = new DataTable("Subjekty");

            //Data adapter, přepíše data ze serveru do lokální tabulky
            SqlDataAdapter prepisovac = new SqlDataAdapter(command);
            prepisovac.Fill(lokalniTabulka);

            zdrojdat = new BindingSource(lokalniTabulka, "");
            
            Binding b1 = new Binding("Text", zdrojdat, "first_name");
            Binding b2 = new Binding("Text", zdrojdat, "last_name");

            textBoxJmeno.DataBindings.Add(b1);
            textBoxPrijmeni.DataBindings.Add(b2);
            dataGridView1.DataSource = zdrojdat;

        }

        private void Previous_Click(object sender, EventArgs e)
        {
            zdrojdat.MovePrevious();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            zdrojdat.MoveNext();
        }
    }
}
