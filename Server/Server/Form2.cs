using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form2 : Form
    {
        Dictionary<String, String> phoneBook = new Dictionary<String, String>();
        Dictionary<String, Socket> ActiveUsers = new Dictionary<String, Socket>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

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
    }
}
