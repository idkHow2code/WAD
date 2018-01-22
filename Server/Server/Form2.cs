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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Server
{
    public partial class Form2 : Form
    {
        Dictionary<String, String> phoneBook = new Dictionary<String, String>();
        public Dictionary<String, Socket> ActiveUsers = new Dictionary<String, Socket>();
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        delegate void SetTextCallback(string text);
        delegate void SetNameCallback(string name);
        delegate void SetActiveUsersCallback(int NoOfConnection);

        Thread threadListen;
        Thread activeClients = null;
        bool clientJoin = false;
        bool clientLeave = false;
        public string name;
        public int connections = 0;
        public Form2()
        {
            InitializeComponent();
            ddlActives.Items.Add("All");
            ddlActives.SelectedIndex = ddlActives.FindStringExact("All");
            threadListen = new Thread(ListenClient);
            threadListen.Start();
            activeClients = new Thread(populateComboBox);
            activeClients.Start();
        }
        /// <summary>
        /// raj work
        /// </summary>
        public void authenticate(Socket Client) //For authentication, check if login is found or not
        {
            NetworkStream ns2 = new NetworkStream(Client);

            byte[] bytes = new byte[1024];

            int bytesName = ns2.Read(bytes, 0, bytes.Length);
            name = Encoding.ASCII.GetString(bytes, 0, bytesName);

            int bytesNum = ns2.Read(bytes, 0, bytes.Length);
            string num = Encoding.ASCII.GetString(bytes, 0, bytesNum);
                
            if (name.Contains("-Registered") == false)
            {
                bool result = login(name, num);
                if (result == true)
                {
                    if (!ActiveUsers.ContainsKey(name))
                    {
                        String s = "Success";
                        byte[] byteTime = Encoding.ASCII.GetBytes(s);
                        ns2.Write(byteTime, 0, byteTime.Length);
                        ns2.Flush();
                        ActiveUsers.Add(name, Client);
                        clientJoin = true;
                        ConnectionHandler handler = new ConnectionHandler(Client, this);
                        ThreadPool.QueueUserWorkItem(new WaitCallback(handler.HandleConnection));
                    }
                    else
                    {
                        String s = "InUsed";
                        byte[] byteTime = Encoding.ASCII.GetBytes(s);
                        ns2.Write(byteTime, 0, byteTime.Length);
                        ns2.Flush();
                    }
                }
                else
                {
                    String s = "Failed";
                    byte[] byteTime = Encoding.ASCII.GetBytes(s);
                    ns2.Write(byteTime, 0, byteTime.Length);
                    ns2.Flush();
                }
                
            }
            else
            {
                name = name.Split('-')[0];
                bool ok = register(name, num);
                if (ok == true)
                {
                    String s = "Registered";
                    byte[] byteTime = Encoding.ASCII.GetBytes(s);
                    ns2.Write(byteTime, 0, byteTime.Length);
                    ns2.Flush();
                    phoneBook.Add(name, num);
                    ActiveUsers.Add(name, Client);
                    clientJoin = true;
                    ConnectionHandler handler = new ConnectionHandler(Client, this);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(handler.HandleConnection));
                }
                else
                {
                    String s = "Nope";
                    byte[] byteTime = Encoding.ASCII.GetBytes(s);
                    ns2.Write(byteTime, 0, byteTime.Length);
                    ns2.Flush();
                }
            }

             

        }

        public void removeClient (Socket client)
        {
            foreach (var person in ActiveUsers)
            {
                if (person.Value == client)
                {
                    ActiveUsers.Remove(person.Key);
                    clientLeave = true;
                }
            }
            
        }

        public void sentfile(string clientName) //Server handle a sent file from the client
        {
            byte[] bytes = new byte[1024];
            foreach (var people in ActiveUsers)
            {
                if (people.Key == clientName)
                {
                    Socket client = people.Value;
                    int bytesName = client.Receive(bytes);
                    string name = Encoding.ASCII.GetString(bytes, 0, bytesName);

                    
                    byte[] sentbytes = new byte[1024 * 5000];
                    int receivedBytesLen = client.Receive(sentbytes);
                    int fileNameLen = BitConverter.ToInt32(sentbytes, 0);

                    if (fileNameLen != 0)
                    {
                        BinaryWriter bWrite = new BinaryWriter(File.OpenWrite(name));
                        bWrite.Write(sentbytes, 4 + fileNameLen, receivedBytesLen - 4 - fileNameLen);
                        bWrite.Close();
                        SetText(clientName + " has sent you a file, named: " + name);
                    }
                }
            }
            
        }
        public void retrieveFile(string ClientName) //Server will send a file to the client
        {
            byte[] bytesReceive = new byte[1024];
            foreach (var people in ActiveUsers)
            {
                if (people.Key == ClientName)
                {
                    Socket client = people.Value;
                    int bytesReceiveLen = client.Receive(bytesReceive);
                    string fileName = Encoding.ASCII.GetString(bytesReceive, 0, bytesReceiveLen);

                    if (File.Exists(fileName))
                    {
                        client.Send(Encoding.ASCII.GetBytes(fileName));
                        byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);
                        byte[] filedata = File.ReadAllBytes(fileName);
                        byte[] clientData = new byte[4 + fileNameByte.Length + filedata.Length];
                        byte[] fileNamLen = BitConverter.GetBytes(fileNameByte.Length);
                        fileNamLen.CopyTo(clientData, 0);
                        filedata.CopyTo(clientData, 4 + fileNameByte.Length);
                        setlabel("Sending");
                        client.Send(clientData);
                        setlabel("Transfer Complete");

                    }
                    else
                    {
                        lblResult.Text = "Please choose a valid file \n";
                    }
                }
            }
        }
        public void setlabel(string text) //Seting the lblResult of the client.
        {
            if (this.lblResult.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                lblResult.Visible = true;
                this.lblResult.Text += text;
            }
        }
        public void SetText(string text)
        {
            if (this.txtChat.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtChat.AppendText(text + Environment.NewLine);
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
            while (true)
            {
                Socket client = server.Accept();
                IPAddress client2addr = ((IPEndPoint)client.RemoteEndPoint).Address;              
                authenticate(client);
            }
        }

        public void SetClient(string name)
        {
            if (this.ddlActives.InvokeRequired)
            {
                SetNameCallback d = new SetNameCallback(SetClient);
                this.Invoke(d, new object[] { name });
            }
            else
            {               
                if (clientJoin)
                {
                    this.ddlActives.Items.Add(name);
                }
                else if (clientLeave)
                {
                    this.ddlActives.Items.Remove(name);
                }
            }
        }

        public void SetLabelNumber(int connection)
        {
            if (this.ddlActives.InvokeRequired)
            {
                SetActiveUsersCallback d = new SetActiveUsersCallback(SetLabelNumber);
                this.Invoke(d, new object[] { connection });
            }
            else
            {
                lblNoOfConnections.Text = Convert.ToString(connection);
            }
        }

        public void populateComboBox()
        {
            while (true)
            {                
                if (clientJoin)
                {
                    SetClient(name);
                    clientJoin = false;
                }
                else if (clientLeave)
                {
                    SetClient(name);
                    clientLeave = false;
                }
                Thread.Sleep(5000);
            }
        }

        public void managelabel()
        {
            while (true)
            {
                SetLabelNumber(connections);
                Thread.Sleep(5000);
            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlActives.SelectedIndex > 0) // not "All"
                {
                    Object selectedItem = ddlActives.SelectedItem;
                    string selectedClient = selectedItem.ToString();
                    foreach (var people in ActiveUsers)
                    {
                        if (selectedClient == people.Key)
                        {
                            Socket Client = people.Value;
                            OpenFileDialog open = new OpenFileDialog();
                            if (open.ShowDialog() == DialogResult.OK)
                            {
                                Client.Send(Encoding.ASCII.GetBytes("SendingFile")); //
                                string fileName = open.SafeFileName;
                                Client.Send(Encoding.ASCII.GetBytes(fileName)); //
                                byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);
                                byte[] filedata = File.ReadAllBytes(fileName);
                                byte[] clientData = new byte[4 + fileNameByte.Length + filedata.Length];
                                byte[] fileNamLen = BitConverter.GetBytes(fileNameByte.Length);
                                fileNamLen.CopyTo(clientData, 0);
                                filedata.CopyTo(clientData, 4 + fileNameByte.Length);

                                SetText("Sending " + fileName);

                                Client.Send(clientData); //

                                SetText("Transfer complete");
                            }
                            else
                            {
                                SetText("Please choose a valid file");
                            }
                        }
                    }
                }
                else
                {
                    SetText("Please select someone");
                }
            }

            catch (Exception Ex)
            {
                SetText(Ex.Message);
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            Object selectedItem = ddlActives.SelectedItem;
            string selectedClient = selectedItem.ToString();
            String s = "Server >> " + txtMessage.Text + "\n";
            if (ddlActives.SelectedIndex > 0) //Not all chat
            {
                foreach (var people in ActiveUsers)
                {
                    if (selectedClient == people.Key)
                    {
                        Socket client = people.Value;
                        NetworkStream ns = new NetworkStream(client);
                        byte[] byteTime = Encoding.ASCII.GetBytes(s);
                        ns.Write(byteTime, 0, byteTime.Length);
                    }
                }
                        
            }
            else if (ddlActives.SelectedIndex == 0) //All chat
            {
                foreach (var people in ActiveUsers)
                {
                    Socket client = people.Value;
                    NetworkStream ns = new NetworkStream(client);
                    byte[] byteTime = Encoding.ASCII.GetBytes(s);
                    ns.Write(byteTime, 0, byteTime.Length);
                }
            }
            txtChat.AppendText(s);
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
            //SaveFileDialog save = new SaveFileDialog();
            //save.Title = "Save File";
            //save.Filter = "Text Files (*.txt)|*.txt";

            //if (save.ShowDialog() == DialogResult.OK)
            //{
            //    StreamWriter write = new StreamWriter(File.Create(save.FileName));

            //    write.Write(txtChat.Text);
            //    write.Dispose();
            //}
            string filepath = Form1.path;
            try
            {
                using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (var line in phoneBook)
                        {
                            sw.WriteLine(line);
                        }
                        SetText("Successfully saved into phonebook ");
                    }
                }
            }
            catch (IOException)
            {
                lblResult.Text = "Failed";
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

        private bool register(string name, string number)
        {
            if (!phoneBook.ContainsKey(name))
            {
                if (!phoneBook.ContainsValue(number))
                {
                    return true;
                }
            }
            return false;
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    class ConnectionHandler
    {
        private Socket client;
        private NetworkStream ns;
        private Form2 form;

        public ConnectionHandler(Socket client, Form2 form)
        {
            this.client = client;
            this.form = form;
        }
        public void HandleConnection(Object state)
        {
            string cName ="";
            try
            {
                ns = new NetworkStream(client);
                form.connections++;

                form.SetText("New client accepted : " + form.connections + " active connections");
                form.SetLabelNumber(form.connections);
                string input = string.Empty;
                byte[] bytes = new byte[1024];
                bool stillActive = true;
                while (stillActive)
                {
                    int bytesRead = ns.Read(bytes, 0, bytes.Length);
                    string clientTxt = Encoding.ASCII.GetString(bytes, 0, bytesRead);
                    if (clientTxt == "Sending \n")
                    {
                        int bytesName = ns.Read(bytes, 0, bytes.Length);
                        string clientName = Encoding.ASCII.GetString(bytes, 0, bytesName);
                        form.sentfile(clientName);
                    }
                    else if (clientTxt == "Receiving \n")
                    {
                        int bytesName = ns.Read(bytes, 0, bytes.Length);
                        string clientName = Encoding.ASCII.GetString(bytes, 0, bytesName);

                        form.retrieveFile(clientName);
                    }
                    else if (clientTxt == "AllChat")
                    {
                        int bytesName = ns.Read(bytes, 0, bytes.Length);
                        string clientName = Encoding.ASCII.GetString(bytes, 0, bytesName);
                        int bits = ns.Read(bytes, 0, bytes.Length);
                        string message = Encoding.ASCII.GetString(bytes, 0, bits);
                        form.SetText(message);
                        foreach (var people in form.ActiveUsers)
                        {
                            if (people.Key != clientName)
                            {
                                Socket otherClient = people.Value;
                                otherClient.Send(Encoding.ASCII.GetBytes(message + "\n"));
                            }
                        }
                    }
                    else if(clientTxt == "Leaving")
                    {
                        int bytesName = ns.Read(bytes, 0, bytes.Length);
                        string clientName = Encoding.ASCII.GetString(bytes, 0, bytesName);
                        form.name = clientName;
                        cName = clientName;
                        stillActive = false;
                    }
                    else
                    {
                        form.SetText(clientTxt);
                    }
                }

                ns.Close();
                client.Close();
                form.removeClient(client);
                form.connections--;
                form.SetLabelNumber(form.connections);
                form.SetText("Client disconnected : " + form.connections + " active connections");

            }
            catch (Exception)
            {
                if (cName.Contains("-Registered"))
                {
                    cName = cName.Split('-')[0];
                }
                form.removeClient(client);
                form.connections--;
                form.SetLabelNumber(form.connections);
                //when client click X
                form.SetText("Client disconnected : " + cName +" "+ form.connections + " active connections");
            }
        }
    }
}
