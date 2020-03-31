using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UDPmes
{
    public partial class Form1 : Form
    {

        #region Konstruktor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion


        #region cancelButton
        /// <summary>
        /// Tlačítko storno uzavře program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Ukončení programu
        }
        #endregion


        #region sendButton
        /// <summary>
        /// Odešle zadaný text na server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSend_Click(object sender, EventArgs e)
        {
            // 1. Vytvoří UDP přípojku (ipv4, datagram, UDP) 
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            // 2. Vytvoření objektu IPadress
            IPAddress ip = IPAddress.Parse("193.85.203.188");

            // 3. Vytvoření a připojení k EndPointu
            IPEndPoint ipEnd = new IPEndPoint(ip, 11500);
            s.Connect(ipEnd); 

            // 4. Napsanou zprávu do pole bytů
            string txt = textIn.Text;
            byte[] zprava = Encoding.Default.GetBytes(txt);

            // 5. Odešle zakódovaná data na server
            s.Send(zprava);


            //Kosmetické úpravy
            textIn.Text = string.Empty;
            textIn.Focus();
        }
        #endregion


    }
}
