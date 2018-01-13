using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form2 : Form
    {
        Dictionary<String, String> phoneBook = new Dictionary<String, String>();
        Dictionary<String, Socket> ActiveUsers = new Dictionary<String, Socket>();
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        delegate void SetTextCallback(string text);
        NetworkStream ns2;
        StreamWriter writer;
        StreamReader reader;
        Thread threadListen;
        Thread threadDoWork = null;
        int connections = 0;
        public Form2()
        {
            InitializeComponent();
            threadListen = new Thread(ListenClient);
            threadListen.Start();
        }
        /// <summary>
        /// raj work
        /// </summary>
        public void DoWork() //reading inputs
        {
            byte[] bytes = new byte[1024];
            reader = new StreamReader(ns2);
            string s = string.Empty;
            while (true)
            {
                if (reader.ReadLine() == "Msg") //does this even work???
                {
                    int bytesRead = ns2.Read(bytes, 0, bytes.Length);
                    this.SetText(Encoding.ASCII.GetString(bytes, 0, bytesRead));
                    //MessageBox.Show(Encoding.ASCII.GetString(bytes, 0, bytesRead));
                }
                else if (reader.ReadLine() == "Login") //this work so how...
                {
                    string loginName = reader.ReadLine();
                    string loginNumber = reader.ReadLine();
                    bool success = login(loginName, loginNumber);
                    if (success)
                    {
                        String successful = "Success";
                        byte[] byteTime = Encoding.ASCII.GetBytes(successful);
                        ns2.Write(byteTime, 0, byteTime.Length);
                    }
                    else
                    {
                        String successful = "Fail User not found";
                        byte[] byteTime = Encoding.ASCII.GetBytes(successful);
                        ns2.Write(byteTime, 0, byteTime.Length);
                    }
                }
            }
        }
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtChat.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtChat.Text += text;
            }
        }
        /// <summary>
        /// raj work
        /// </summary>

        public void ListenClient() //thread to listen for clients
        {
            IPEndPoint localEP = new IPEndPoint(IPAddress.Any, 9049);
            server.Bind(localEP);
            server.Listen(10);
            Socket client = server.Accept();
            IPAddress client2addr = ((IPEndPoint)client.RemoteEndPoint).Address;
            ns2 = new NetworkStream(client);
            connections++;
            this.SetText("New client accepted : " + connections + " active connections");
            threadDoWork = new Thread(DoWork);
            threadDoWork.Start();
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String s = "Server >> " + txtMessage.Text + "\n";
            txtChat.AppendText(s);
            byte[] byteTime = Encoding.ASCII.GetBytes(s);
            ns2.Write(byteTime, 0, byteTime.Length);
           
        }


        private void ddlActives_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void receive(Dictionary<string, string> form1PhoneBook)
        {
            foreach (var person in form1PhoneBook)
            {
                phoneBook.Add(person.Key, person.Value);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save File";
            save.Filter = "Text Files (*.txt)|*.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));

                write.Write(txtChat.Text);
                write.Dispose();
            }
        }



        private bool login(string name,string number)
        {
            if (phoneBook.ContainsKey(name))
            {
                if (phoneBook[name] == number)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
