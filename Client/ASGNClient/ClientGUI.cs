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
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace WK7_QTN2_Client
{
    public partial class ChatApplication : Form
    {

        NetworkStream serverStream; //Create the server stream 
        Thread chatThread = null; //Chat thread for starting the chat process
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        SpeechSynthesizer aSynth = new SpeechSynthesizer();
        PromptBuilder pbuilder = new PromptBuilder();
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();

        delegate void SetTextCallback(string text);
        public string loginResult;
        private string ClientName;
        public bool logOut = false;


        public ChatApplication() //Connect to the server
        {
                InitializeComponent();

                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse
                                                 ("127.0.0.1"), 9049);

                try
                {
                    socket.Connect(remoteEP);
                    chat.Text = "Connected to server \n";
                }
                catch (SocketException e)
                {
                    String a = "Unable to connect to server.";
                    a += e;
                    chat.Text = a;

                    return;
                }
                serverStream = new NetworkStream(socket);
            
        }
        private void ClientGUI_Load(object sender, EventArgs e) //If connected to server success, it will load the Client chat GUI accordingly
        {            

            passLogin();
            if (loginResult != "Success" && loginResult != "Registered")
            {
                this.Close();
            }
            else
            {
           
                chat.Visible = true;
                clientTxtv2.Visible = true;
                sendV2.Visible = true;
                openDialogV2.Visible = true;
                ClientName = Login.passingName;
                nameOnline.Text = "Welcome " + ClientName.Split('-')[0];
                if(clientTxtv2.Text != null)
                {
                    chatThread = new Thread(DoWork);
                    chatThread.Start();
                }

            }
        }
        private string passLogin() //Pass the login credentials to the server
        {
            string resultFromServer = "";
            try
            {

                if (Login.passingName != null && Login.passingNum != null)
                {

                    string name = Login.passingName;
                    string num = Login.passingNum;

                    socket.Send(Encoding.ASCII.GetBytes(name));
                    socket.Send(Encoding.ASCII.GetBytes(num));

                    byte[] bytelogin = new byte[1024];

                    int size = socket.Receive(bytelogin);
                    resultFromServer = Encoding.ASCII.GetString(bytelogin, 0, size);
                    loginResult = resultFromServer;
                }

            }
            catch (Exception q)
            {

                this.SetText("" + q);
            }
            return resultFromServer;

        }
        //private void getFile_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        socket.Send(Encoding.ASCII.GetBytes("Receiving \n")); //protocol
        //        socket.Send(Encoding.ASCII.GetBytes(ClientName)); //send my name
        //        socket.Send(Encoding.ASCII.GetBytes(clientText.Text)); //name of file you want

        //        //NetworkStream ns1 = new NetworkStream(socket);

        //        byte[] sentbytes = new byte[1024 * 5000];
        //        int receivedBytesLen = socket.Receive(sentbytes); //wait for receive
        //        int fileNameLen = BitConverter.ToInt32(sentbytes, 0);

        //        SetText("Received \n");
        //        if (fileNameLen != 0)
        //        {
        //            BinaryWriter bWrite = new BinaryWriter(File.OpenWrite(clientText.Text));
        //            bWrite.Write(sentbytes, 4 + fileNameLen, receivedBytesLen - 4 - fileNameLen);
        //            bWrite.Close();

        //        }
        //    }
        //    catch (Exception a)
        //    {

        //        this.SetText(""+a);
        //    }
           
        //}
        //Do work is run as a thread and will be mainly used for the chat process
        //It will read the bytes sent by the server and then call SetText which will display it on the chat box
        public void DoWork()

        {
            try
            {
                byte[] bytes = new byte[1024];

                while (true)

                {

                    int bytesRead = serverStream.Read(bytes, 0, bytes.Length);
                    string text = Encoding.ASCII.GetString(bytes, 0, bytesRead);
                    if (text == "SendingFile")
                    {
                        gettingFile();
                    }
                    else
                    {
                        this.SetText(text);
                    }
                    Thread.Sleep(1000);
                    //MessageBox.Show(Encoding.ASCII.GetString(bytes, 0, bytesRead));

                }

            }
            catch (Exception e)
            {

                this.SetText(""+e);
            }

        }
        // InvokeRequired required compares the thread ID of the

            // calling thread to the thread ID of the creating thread.

        // If these threads are different, it returns true.
        private void SetText(string text)
        {
            try
            {
                if (this.chat.InvokeRequired)

                {

                    SetTextCallback d = new SetTextCallback(SetText);

                    this.Invoke(d, new object[] { text });

                }
                else
                {

                    this.chat.Text += /*this.richTextBox1.Text +*/ text;

                }
            }
            catch (Exception)
            {
                Login reLogin = new Login();
                reLogin.Show();
                this.Close();
            }
            
        }

        public void gettingFile()
        {
            byte[] bytes = new byte[1024];
            int bytesName = socket.Receive(bytes);
            string name = Encoding.ASCII.GetString(bytes, 0, bytesName);


            byte[] sentbytes = new byte[1024 * 5000];
            int receivedBytesLen = socket.Receive(sentbytes);
            int fileNameLen = BitConverter.ToInt32(sentbytes, 0);

            if (fileNameLen != 0)
            {
                BinaryWriter bWrite = new BinaryWriter(File.OpenWrite(name));
                bWrite.Write(sentbytes, 4 + fileNameLen, receivedBytesLen - 4 - fileNameLen);
                bWrite.Close();
                SetText("Server has sent you a file, named: " + name);
            }
        }

        //User to send their chat to the server     
        private void sendConfirm_Click(object sender, EventArgs e)
        {
            ClientName = ClientName.Split('-')[0];
            String s = ClientName + " >> " + clientTxtv2.Text;
            byte[] byteTime = Encoding.ASCII.GetBytes(s);
            if (chkAllV2.Checked)
            {
                socket.Send(Encoding.ASCII.GetBytes("AllChat")); //protocol
                socket.Send(Encoding.ASCII.GetBytes(ClientName)); //send my name
                serverStream.Write(byteTime, 0, byteTime.Length);
            }
            else
            {
                serverStream.Write(byteTime, 0, byteTime.Length);
            }
            chat.Text += s + Environment.NewLine;
        }
        //User will select the file they want to send to the server via OpenDialog
        private void openDialogV2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                socket.Send(Encoding.ASCII.GetBytes("Sending \n"));
                socket.Send(Encoding.ASCII.GetBytes(ClientName)); //send my name
                string fileName = open.SafeFileName;
                socket.Send(Encoding.ASCII.GetBytes(fileName));
                byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);
                byte[] filedata = File.ReadAllBytes(fileName);
                byte[] clientData = new byte[4 + fileNameByte.Length + filedata.Length];
                byte[] fileNamLen = BitConverter.GetBytes(fileNameByte.Length);
                fileNamLen.CopyTo(clientData, 0);
                filedata.CopyTo(clientData, 4 + fileNameByte.Length);

                chat.Text += "Sending \n";

                socket.Send(clientData);

                chat.Text += "Transfer complete \n";
            }
            else
            {
                chat.Text = "Please choose a valid file \n";
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            //SaveFileDialog save = new SaveFileDialog();
            //save.Title = "Save File";
            //save.Filter = "Text Files (*.txt)|*.txt";

            //if (save.ShowDialog() == DialogResult.OK)
            //{
            //    StreamWriter write = new StreamWriter(File.Create(save.FileName));

            //    write.Write(clientChatBox.Text);
            //    write.Dispose();
            //}
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void clientText_TextChanged(object sender, EventArgs e)
        {

        }

        private void speakV2_Click(object sender, EventArgs e)
        {
            speakV2.Enabled = false;
            stopV2.Enabled = true;
            string pathWords = "speechRecognition.txt";
            Choices sList = new Choices();
            Choices sListSimple = new Choices();
            sListSimple.Add(new string[] { "hello", "how", "are", "you", "test", "testing", "working" });
            if (File.Exists(pathWords))
            {
                StreamReader reader = File.OpenText(pathWords);
                string line = null;
                List<string> words = new List<string>();
                while ((line = reader.ReadLine()) != null)
                {
                    sList.Add(line);
                }
                Grammar grSimple = new Grammar(new GrammarBuilder(sListSimple));
                Grammar gr = new Grammar(new GrammarBuilder(sList));
                try
                {
                    sRecognize.RequestRecognizerUpdate();
                    sRecognize.LoadGrammar(grSimple);
                    sRecognize.SpeechRecognized += SRecognize_SpeechRecognized;
                    sRecognize.SetInputToDefaultAudioDevice();
                    sRecognize.RecognizeAsync(RecognizeMode.Multiple);
                }
                catch
                {

                    sRecognize.RequestRecognizerUpdate();
                    sRecognize.LoadGrammar(gr);
                    sRecognize.SpeechRecognized += SRecognize_SpeechRecognized;
                    sRecognize.SetInputToDefaultAudioDevice();
                    sRecognize.RecognizeAsync(RecognizeMode.Multiple);
                }
            }

        }
        private void stopV2_Click(object sender, EventArgs e)
        {
            sRecognize.RecognizeAsyncStop();
            speakV2.Enabled = true;
            stopV2.Enabled = false;
        }

        private void SRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "exit")
            {
                Application.Exit();
            }
            else if (clientTxtv2.Text == null)
            {
                clientTxtv2.Text = clientTxtv2.Text + " " + e.Result.Text.ToString();

            }
            else
            {
                clientTxtv2.Text += " " + e.Result.Text.ToString();
            }

        }
        private void getFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            socket.Send(Encoding.ASCII.GetBytes("Leaving")); //protocol
            socket.Send(Encoding.ASCII.GetBytes(ClientName)); //send my name
            socket.Close();
            Login reLogin = new Login();
            reLogin.Show();
        }

        private void loginSuccess_Click(object sender, EventArgs e)
        {

        }

        private void clientTxtv2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chat_Click(object sender, EventArgs e)
        {

        }

        private void lblHello_Click(object sender, EventArgs e)
        {

        }

    }
}
