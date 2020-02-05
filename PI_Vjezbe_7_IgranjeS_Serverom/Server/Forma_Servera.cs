using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Forma_Servera : Form
    {
        public Forma_Servera()
        {
            InitializeComponent();
            netSocket.ExclusiveAddressUse = false;
            netSocketServerArgs.Completed += netSocketServerArgs_Completed;
            netSocketServerArgs.SetBuffer(netSocketBuffer, 0, 1024);//jako bitno

        }
        private Socket netSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private SocketAsyncEventArgs netSocketServerArgs = new SocketAsyncEventArgs();
        private byte[] netSocketBuffer = new byte[1024];
        private void WriteToLog(string message)
        {
            porukaPrimljena.Invoke((MethodInvoker)delegate
            {
                porukaPrimljena.Text = message + Environment.NewLine + porukaPrimljena.Text;
            });
        }

        private void StartListening()
        {
            netSocket.Bind(new IPEndPoint(IPAddress.Any, 8087));
            netSocket.ReceiveAsync(netSocketServerArgs);
            WriteToLog("listening");
        }
        string proba;
        
        void netSocketServerArgs_Completed(object sender, SocketAsyncEventArgs e)
        {
           proba = UTF8Encoding.UTF8.GetString(netSocketServerArgs.Buffer, 0, e.BytesTransferred);
            proba.Reverse();
            if (netSocketServerArgs.LastOperation == SocketAsyncOperation.Receive)
            {
               
                WriteToLog("message: " + UTF8Encoding.UTF8.GetString(netSocketServerArgs.Buffer, 0, e.BytesTransferred));
                netSocket.ReceiveAsync(netSocketServerArgs);
            }
        }

        private void unosSlusajPotvrda_Click(object sender, EventArgs e)
        {
            StartListening();
        }
        
        private void unosProvjera_Click(object sender, EventArgs e)
        {
        //    int prvi = 0;
        //    int drugi = 0;
        //    string[] brojevi= proba.Split(',');
        //    prvi = int.Parse(brojevi[0]);
        //    drugi = int.Parse(brojevi[1]);
        //    testPrimanja.Text = (prvi + drugi).ToString();
        }
    }
}



