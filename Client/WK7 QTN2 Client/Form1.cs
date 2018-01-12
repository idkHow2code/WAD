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
    public partial class Form1 : Form
    {
        private const int portNum = 4545;

        delegate void SetTextCallback(string text);



        //TcpClient client;

        NetworkStream ns;

        Thread t = null;

        private const string hostName = "localhost";
        public Form1()
        {
            InitializeComponent();
            //client = new TcpClient(hostName, portNum);

            //ns = client.GetStream();

            Socket socket = new Socket(AddressFamily.InterNetwork,
                          SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse
                                             ("127.0.0.1"), 9050);
            try
            {
                socket.Connect(remoteEP);
                richTextBox1.Text = "Connected to server \n";
            }
            catch (SocketException e)
            {
                String a = "Unable to connect to server.";
                a += e;
                richTextBox1.Text = a;

                return;
            }

            String s = "Connected";

            byte[] byteTime = Encoding.ASCII.GetBytes(s);

            ns = new NetworkStream(socket);
            ns.Write(byteTime, 0, byteTime.Length);

            t = new Thread(DoWork);

            t.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text + "\n";
            richTextBox1.AppendText(s);

            byte[] byteTime = Encoding.ASCII.GetBytes(s);

            ns.Write(byteTime, 0, byteTime.Length);

        }
        public void DoWork()

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

            // InvokeRequired required compares the thread ID of the

            // calling thread to the thread ID of the creating thread.

            // If these threads are different, it returns true.

            if (this.richTextBox1.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(SetText);

                this.Invoke(d, new object[] { text });

            }

            else

            {

                this.richTextBox1.Text += /*this.richTextBox1.Text +*/ text;

            }

        }
    }
}
