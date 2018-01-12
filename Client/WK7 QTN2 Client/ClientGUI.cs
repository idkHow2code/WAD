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
using System.IO;
using System.Threading;

namespace WK7_QTN2_Client
{
    public partial class ClientGUI : Form
    {
        delegate void SetTextCallback(string text);
        NetworkStream ns;
        StreamWriter writer;
        Thread t = null; //maybe this thread is not reaching the server?
        Socket socket;
        public ClientGUI()
        {
            InitializeComponent();
            socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9049);
            try
            {
                socket.Connect(remoteEP);
                clientChatBox.Text = "Connected to server \n";
            }
            catch (SocketException e)
            {
                String a = "Unable to connect to server.";
                a += e;
                clientChatBox.Text = a;

                return;
            }
            String s = "Connected";
            byte[] byteTime = Encoding.ASCII.GetBytes(s);
            ns = new NetworkStream(socket);
            ns.Write(byteTime, 0, byteTime.Length);
            t = new Thread(DoWork2);
            t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void DoWork2()
        {
            byte[] bytes = new byte[1024];
            while (true)
            {
                int bytesRead = ns.Read(bytes, 0, bytes.Length);
                this.SetText(Encoding.ASCII.GetString(bytes, 0, bytesRead));
                //MessageBox.Show(Encoding.ASCII.GetString(bytes, 0, bytesRead));
            }
        }

        private void SetText(string text)
        {
            if (this.clientChatBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.clientChatBox.Text += /*this.richTextBox1.Text +*/ text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = "Client >> " + clientTxt.Text + "\n";
            clientChatBox.AppendText(s);
            writer = new StreamWriter(ns);
            writer.WriteLine("Msg"); //trigger "Msg from Server side..."
            writer.Flush();
            byte[] byteTime = Encoding.ASCII.GetBytes(s);
            ns.Write(byteTime, 0, byteTime.Length); //do i need do work?
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
