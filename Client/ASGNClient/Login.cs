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
using System.Text.RegularExpressions;

namespace WK7_QTN2_Client
{
    public partial class Login : Form
    {


        public static string passingName;
        public static string passingNum;
        public static bool register = false;
        
        public Login()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void No_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string namePattern = @"^[a-zA-Z ]*$";
            Regex num = new Regex(@"^[0-9]*$");
            Regex name = new Regex(namePattern);

            passingName = nameTxt.Text;
            passingNum = numTxt.Text;

            bool y = name.IsMatch(passingName);
            bool x = num.IsMatch(passingNum);

            if (x == true && y == true)
            {

                ChatApplication clientGUI = new ChatApplication();
                clientGUI.Show();
                if (clientGUI.loginResult == "Success")
                {
                    this.Hide();
                }
                else if (clientGUI.loginResult == "InUsed")
                {
                    lblResult.Text = "User has been logged into the system";
                }
                else
                {
                    lblResult.Text = "Login Failed!";
                }
                numCatch.Visible = false;
                nameCatch.Visible = false;
            }
            else if (x == false && y == false)
            {
                numCatch.Visible = true;
                nameCatch.Visible = true;
            }
            else if (x == false)
            {
                numCatch.Visible = true;
            }
            else if (y == false)
            {
                nameCatch.Visible = true;
            }

        }
       
        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (logInTab.Left == 420)
            {
                signUpTab.Visible = false;
                signUpTab.Left = 420;
                signUpConfirm.Visible = false;
                signUpConfirm.Left = 420;

                logInTab.Visible = false;
                logInTab.Left = 65;
                logInTab.Visible = true;
                loginConfirm.Visible = false;
                loginConfirm.Left = 65;
                loginConfirm.Visible = true;
                logInTab.Refresh();

                bunifuSeparator2.Left = signUpNumTxt.Left;
                bunifuSeparator2.Width = signUpNumTxt.Width;
            }
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            int x = signUpTab.Left;
            int y = signUpConfirm.Left;
            if (signUpTab.Left == 420)
            {
                logInTab.Visible = false;
                loginConfirm.Visible = false;
                logInTab.Left = 420;
                loginConfirm.Left = 420;

                signUpTab.Visible = false;
                signUpTab.Left = 65;
                signUpTab.Visible = true;
                signUpConfirm.Visible = false;
                signUpConfirm.Left = 65;
                signUpConfirm.Visible = true;
                signUpTab.Refresh();

                bunifuSeparator2.Left = signUp.Left;
                bunifuSeparator2.Width = signUp.Width;
            }
        }

        private void signUpConfirm_Click(object sender, EventArgs e)
        {
            string namePattern = @"^\D+$";
            Regex num = new Regex(@"^[0-9]*$");
            Regex name = new Regex(namePattern);

            passingName = signUpNameTxt.Text + "-Registered";
            passingNum = richTextBox2.Text;

            bool y = name.IsMatch(passingName);
            bool x = num.IsMatch(passingNum);

            if (x == true && y == true)
            {
                register = true;
                ChatApplication clientGUI = new ChatApplication();
                clientGUI.Show();
                if (clientGUI.loginResult == "Registered")
                {
                    this.Hide();
                }
                else if (clientGUI.loginResult == "Existed")
                {
                    lblResult.Text = "User already exist";
                }
                else
                {
                    lblResult.Text = "Register Failed!";
                }
                numCatch.Visible = false;
                nameCatch.Visible = false;
            }
            else if (x == false && y == false)
            {
                numCatch.Visible = true;
                nameCatch.Visible = true;
            }
            else if (x == false)
            {
                numCatch.Visible = true;
            }
            else if ( y == false)
            {
                nameCatch.Visible = true;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void nameTxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
