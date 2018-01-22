using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        ArrayList tempList = new ArrayList();
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        public static string path = "PhoneBook.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(path))
                {
                    StreamReader reader = File.OpenText(path);
                    string line = null;
                    int count = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        tempList.Add(line);
                    }
                    foreach (string people in tempList)
                    {
                        string[] temp = Convert.ToString(tempList[count]).Split(';');
                        string Name = Convert.ToString(temp[0]);
                        Name = Name.Trim();
                        string Number = Convert.ToString(temp[1]);
                        Number = Number.Trim();
                        phoneBook.Add(Name, Number);
                        count++;
                    }
                    reader.Close();
                    lblResult.Text = phoneBook.Count + " people loaded successfully";
                    this.Hide();
                    Form2 server = new Form2();
                    server.receive(phoneBook);
                    server.FormClosed += new FormClosedEventHandler(server_Closed);
                    server.ShowDialog();
                }
            }
            catch (IOException)
            {
                lblResult.Text = "Unable to Load File";
            }
        }

        void server_Closed(object sender, FormClosedEventArgs e)
        {
            // Do whatever you want here
            this.Close();
        }
    }
}
