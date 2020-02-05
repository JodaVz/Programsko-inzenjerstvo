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

namespace PI_Vjezbe_7_IgranjeS_Serverom
{
    public partial class Forma_Klijenta : Form
    {
        public Forma_Klijenta()
        {
            InitializeComponent();
            netSocket.ExclusiveAddressUse = false;
            netClientServerArgs.SetBuffer(netSocketBuffer, 0, 1024);
            netClientServerArgs1.SetBuffer(netSocketBuffer, 0, 1024);
            netClientServerArgs.RemoteEndPoint = new IPEndPoint(IPAddress.Loopback, 12000);
            netClientServerArgs1.RemoteEndPoint = new IPEndPoint(IPAddress.Loopback, 11000);
        }
        private Socket netSocket = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
        private SocketAsyncEventArgs netClientServerArgs = new SocketAsyncEventArgs();
        private byte[] netSocketBuffer = new byte[1024];
        private Socket netSocket1 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private SocketAsyncEventArgs netClientServerArgs1 = new SocketAsyncEventArgs();
        private byte[] netSocketBuffer1 = new byte[1024];

        private void MessageSend(string message)
        {
            netSocketBuffer = UTF8Encoding.UTF8.GetBytes(message);
            netClientServerArgs.SetBuffer(netSocketBuffer, 0, netSocketBuffer.Length);
            netSocket.SendToAsync(netClientServerArgs);
        }

        private void posaljiPoruku_Click(object sender, EventArgs e)
        {
            MessageSend(unosPoruka.Text);
             
        }

        private void unosIpPotvrda_Click(object sender, EventArgs e)
        {
           
        }
        private void MessageSend1(string poruka)
        {
            netSocketBuffer1 = UTF8Encoding.UTF8.GetBytes(poruka);
            netClientServerArgs1.SetBuffer(netSocketBuffer1, 0, netSocketBuffer1.Length);
            netSocket1.SendToAsync(netClientServerArgs1);
        }
        private void brojac_Tick(object sender, EventArgs e)
        {
            MessageSend1("ping");
        }

        private void unosHashPotvrda_Click(object sender, EventArgs e)
        {
            MessageSend(unosHash.Text);
        }
        string recenica;
        private void unosRecenicePotvrda_Click(object sender, EventArgs e)
        {
            try
            {
                recenica = unosRecenice.Text;
                
                recenica = new string(recenica.ToCharArray().Reverse().ToArray());
            }
            catch (Exception)
            {

                MessageBox.Show("Mora biti nekej");
            }
            
            MessageSend(recenica);
        }
    }
}
