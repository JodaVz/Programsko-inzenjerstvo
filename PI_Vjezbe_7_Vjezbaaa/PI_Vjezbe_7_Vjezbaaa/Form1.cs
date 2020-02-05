using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;

namespace PI_Vjezbe_7_Vjezbaaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            netSocketPrvi.ExclusiveAddressUse = false;

            netClientServerArgsPrvi.SetBuffer(netSocketBufferPrvi, 0, 1024);
            netClientServerArgsPING.SetBuffer(netSocketBufferPING, 0, 1024);
            netClientServerArgsPrvi.RemoteEndPoint= new IPEndPoint(IPAddress.Loopback, 11000);
            netClientServerArgsPING.RemoteEndPoint = new IPEndPoint(IPAddress.Loopback, 12000);
            Thread dretva = new Thread(PingSendDretva);
            dretva.Start();
        }
        private Socket netSocketPrvi = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
        private SocketAsyncEventArgs netClientServerArgsPrvi = new SocketAsyncEventArgs();
        private byte[] netSocketBufferPrvi = new byte[1024];
        //za ping socket
        private Socket netSocketPING = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private SocketAsyncEventArgs netClientServerArgsPING = new SocketAsyncEventArgs();
        private byte[] netSocketBufferPING = new byte[1024];


        private void MessageSend(string message)
        {
            netSocketBufferPrvi = UTF8Encoding.UTF8.GetBytes(message);
            netClientServerArgsPrvi.SetBuffer(netSocketBufferPrvi, 0, netSocketBufferPrvi.Length);
            netSocketPrvi.SendToAsync(netClientServerArgsPrvi);
        }        private void PingSend()
        {
            netSocketBufferPING = UTF8Encoding.UTF8.GetBytes("Ping");
            netClientServerArgsPING.SetBuffer(netSocketBufferPING, 0, netSocketBufferPING.Length);
            netSocketPING.SendToAsync(netClientServerArgsPING);
        }
        private void PingSendDretva()
        {
            while (true)
            {
                netSocketBufferPING = UTF8Encoding.UTF8.GetBytes("Ping");
                netClientServerArgsPING.SetBuffer(netSocketBufferPING, 0, netSocketBufferPING.Length);
                netSocketPING.SendToAsync(netClientServerArgsPING);
                Thread.Sleep(900);
            }
            
        }

        private void brojac_Tick(object sender, EventArgs e)
        {
           // PingSend();
        }

        string poruka;
        private void unosTekstaPotvrda_Click(object sender, EventArgs e)
        {
            
            try
            {
                poruka = Convert.ToString(int.Parse(unosTeksta.Text), 2);
                MessageSend(poruka);
            }
            catch (Exception)
            {
                MessageBox.Show("Mora biti broj");
                
            }
           
            
        }
    }
}
