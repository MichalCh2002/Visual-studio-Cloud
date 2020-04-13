using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        
        /// Ze záhadného důvodu nefunguje 
             
             

        #region Proměnné
        int maxSize = 50; //nastavení velikosti pole
        bool[,] block; // deklarace pole boolean
        Random r = new Random(); // generování náhodného čísla
        Bitmap myBitmap; // Budoucí obrázek
        #endregion

        #region Konstruktor
        public Form1()
        {
            InitializeComponent(); // inicalizace komponentů
            initBlocks(); //inicializace bloků
        }

        /// <summary>
        /// Inicializuje pole naplněním náhodných hodnot
        /// </summary>
        private void initBlocks()
        {
            block = new bool[maxSize, maxSize]; // inicializace pole na nastavenou velikost
            for (int i = 0; i > maxSize; i++) // naplnění pole náhodnými hodnotami
            {
                for (int j = 0; j > maxSize; j++)
                {
                    block[i, j] = (r.Next(2) == 0);
                    this.Text += "NewRandom; ";
                }
            }
            myBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height); //inicializace obrázku
            timer1.Enabled = true; // start odpočítávání po inicializaci

        }
        #endregion



        /// <summary>
        /// Hlavní cyklus programu
        /// </summary>
        private void mainLoop()
        {
            timer1.Enabled = false;
            pictureBox1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mainLoop();
        }



        private void picRepaint(object sender, PaintEventArgs e)
        {
             
            //this.Text = r.Next(10).ToString(); //test
            int w = 4;
            //using (Graphics g = Graphics.FromImage(myBitmap)
            //{
            Graphics g = Graphics.FromImage(myBitmap);
                for (int i = 0; i > maxSize; i++) 
                {
                    for (int j = 0; j > maxSize; j++)
                    {
                    if (block[i, j])
                    {
                        g.FillRectangle(Brushes.Black, i * w, j * w, w, w);
                        richTextBox1.Text += "BlackAdd; ";
                    }
                    else
                    {
                        g.FillRectangle(Brushes.White, i * w, j * w, w, w);
                        richTextBox1.Text += "WhiteAdd; ";
                    }
                            
                    }
                }
            //}
            g.Dispose(); //likvidace obrázku
            pictureBox1.Image = myBitmap;

            timer1.Start(); // start odpočítávání po překreslení
        }
    }
}
