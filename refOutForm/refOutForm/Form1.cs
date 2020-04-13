using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace refOutForm
{
    public partial class Form1 : Form
    {
        #region Konstruktor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Close 
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Navigační tlačítka
        private void btnUvod_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageIndex = 7;
        }


        #endregion

        #region str1
        private void btnProhodit1_Click(object sender, EventArgs e)
        {
            // zadané hodnoty
            int c1 = int.Parse(txtBxCislo1.Text);
            int c2 = int.Parse(txtBxCislo2.Text);
            
            // prohození
            swipe(ref c1,ref c2);

            // výsledný výpis
            txtBxCislo1.Text = c1.ToString();
            txtBxCislo2.Text = c2.ToString();
        }
        /// <summary>
        /// Prohodí hodnoty 
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        public static void swipe(ref int c1,ref int c2)
        {
            int p = c1;
            c1 = c2;
            c2 = p;

        }

        // kosmetická úprava
        private void tabPage2_Click(object sender, EventArgs e)
        {
            tabPage2.Focus();
        }

        #endregion

        #region str2
        // kosmetika
        private void tabPage3_Click(object sender, EventArgs e)
        {
            tabPage3.Focus();
        }

        /// <summary>
        /// převede zadané přebytečné sekundy na celé minuty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevest2_Click(object sender, EventArgs e)
        {
            // zadané hodnoty
            int min = int.Parse(txtBxMinuty.Text);
            int sec = int.Parse(txtBxSekundy.Text);

            // korekce
            korekceCasu(ref min,ref sec);

            // Výpis
            txtBxMinuty.Text = min.ToString();
            txtBxSekundy.Text = sec.ToString();
        }

        /// <summary>
        /// statická metoda, co převede přebytečné sekundy na celé minuty
        /// </summary>
        /// <param name="min"></param>
        /// <param name="sec"></param>
        public static void korekceCasu(ref int min, ref int sec)
        {
            if (sec > 60)
            {
                min += sec / 60;
                sec -= (sec / 60) * 60;
            }
        }
        #endregion

        #region str3
        /// <summary>
        /// Ciferný součet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVypocitat3_Click(object sender, EventArgs e)
        {
            // zadaná cifra
            int cifra = int.Parse(txtBxCifra.Text);
            // místo pro výsledek
            int soucet;

            //ciferný součet
            cifernySoucet(ref cifra,out soucet);

            //výpis
            txtBxCifraReslt.Text = soucet.ToString();

        }

        /// <summary>
        /// vypočítá ciferný součet čísla
        /// </summary>
        /// <param name="cifra"></param>
        public static void cifernySoucet(ref int cifra, out int soucet)
        {
            int vysledek = 0;

            while (cifra>0)
            {
                vysledek += (cifra % 10);
                cifra /= 10;
            }

            soucet = vysledek;
        }

        //kosmetika
        private void tabPage4_Click(object sender, EventArgs e)
        {
            tabPage4.Focus();
        }


        #endregion

        //#region str4

        Random r = new Random();
        int[] pole = new int[10];

        /// <summary>
        /// vygeneruje a vypíše pole 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNacist4_Click(object sender, EventArgs e)
        {
            txtBxPoleOut.Text = string.Empty;

            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = r.Next(10);
            }

            foreach (int i in pole)
            {
                txtBxPoleOut.Text += i + " - ";
            }
        }

        private void btnVynulovat4_Click(object sender, EventArgs e)
        {
            txtBxPoleOut.Text = string.Empty;
            vynulovatPole(ref pole);
            foreach (int i in pole)
            {
                txtBxPoleOut.Text += i + " - ";
            }

        }

        public static void vynulovatPole(ref int[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = 0;
            }
        }




    }
}
