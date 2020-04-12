using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCP
{
    



    class TCPServer
    {

        private TcpListener server;
        private bool isRunning;

        public TCPServer(int port)
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();
            isRunning = true;

            loopClients();
        }

        /// <summary>
        /// Příjem nových klientů
        /// </summary>
        private void loopClients()
        {
            while (isRunning) //čekání na klienta 
            {
                TcpClient newClient = server.AcceptTcpClient(); 
                Thread t = new Thread(new ParameterizedThreadStart(HandleClient)); //vytvoření nového vlákna pro komunikaci s klientem
                t.Start(newClient);
            }
        }

        /// <summary>
        /// Příjem a odesílání dat od klienta
        /// </summary>
        /// <param name="obj"></param>
        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj; //přetypování na tcp klienta, vlákna pracují s obj
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.UTF8);
            StreamWriter sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);

            bool clientConnected = true;
            string sData = null; //pomocná proměnná pro práci s txt řetězci
            sWriter.WriteLine("Přippojeno k serveru");
            sWriter.Flush();

            while (clientConnected)
            {
                sData = sReader.ReadLine();
                Console.WriteLine("Cient ->" + sData); //výpis co poslal klient
                sWriter.WriteLine("Ahoj");
                sWriter.Flush();
            }

        }
    }
}
