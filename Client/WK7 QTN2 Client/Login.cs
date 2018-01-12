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
    public partial class Login : Form
    {
        private bool a = false;
        private const int portNum = 4545;
        delegate void SetTextCallback(string text);
        StreamWriter writer;
        StreamReader reader;
        //TcpClient client;
        bool connected = false;
        NetworkStream ns;
        Thread t = null;
        Thread t2 = null;
        Socket socket;

        public Login()
        {
            InitializeComponent();
            socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9049);
            try
            {
                socket.Connect(remoteEP);
            }
            catch (SocketException e)
            {
                String a = "Unable to connect to server.";
                a += e;

                return;
            }
            String s = "Connected";
            connected = true;
            byte[] byteTime = Encoding.ASCII.GetBytes(s);
            ns = new NetworkStream(socket);
            ns.Write(byteTime, 0, byteTime.Length);
            t = new Thread(DoWork);
            t.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (connected == false)
            {
                result.Text = "Unable to connect to server please try again later";
                result.Visible = true;
            }
        }

        private void No_Click(object sender, EventArgs e)
        {

        }

        public void DoWork()
        {
            if (a == false)
            {
                byte[] bytes = new byte[1024];
                while (true)
                {
                    int bytesRead = ns.Read(bytes, 0, bytes.Length);
                    this.SetName(Encoding.ASCII.GetString(bytes, 0, bytesRead)); //these code... something is off
                    //MessageBox.Show(Encoding.ASCII.GetString(bytes, 0, bytesRead));
                }
            }
            else
            {                
                ClientGUI op = new ClientGUI();
                op.Show();
            }
        }

        private void SetName(string text)
        {
             if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetName);
                this.Invoke(d, new object[] { text });
            }
            else if (text == "Success") //maybe the reason why i must double click Login is because of this
            {
                result.Text = "Welcome" + text;
                result.Visible = true;
                String conn = "Connected...";
                byte[] byteName = Encoding.ASCII.GetBytes(conn);
                ns.Write(byteName, 0, byteName.Length);
                a = true;
                DoWork();               
            }
            else if (text != "Success")
            {
                result.Text = text;
                result.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
            }
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.          
        }

        private void button1_Click_1(object sender, EventArgs e) //why must i double click twice before i can log in?
        {
            String name = textBox1.Text;
            String num = textBox2.Text;
            writer = new StreamWriter(ns); //all these login stuff works. don't touch them
            writer.WriteLine("Login");
            writer.WriteLine(name);
            writer.WriteLine(num);
            writer.Flush();
            t2 = new Thread(DoWork);
            t2.Start();
        }
        //private void SetNum(string text)
        //{
        //    // InvokeRequired required compares the thread ID of the
        //    // calling thread to the thread ID of the creating thread.
        //    // If these threads are different, it returns true.
        //    if (this.textBox2.InvokeRequired)
        //    {
        //        SetTextCallback d = new SetTextCallback(SetName);
        //        this.Invoke(d, new object[] { text });
        //    }
        //    else
        //    {
        //        if (text != "Success")
        //        {
        //            result.Text = text;
        //            result.Visible = true;
        //        }
        //        else
        //        {
        //            result.Text = "Welcome" + text;
        //            result.Visible = true;
        //        }
        //    }
        //}
    }
}
