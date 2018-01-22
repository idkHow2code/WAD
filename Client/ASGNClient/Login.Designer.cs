using System;

namespace WK7_QTN2_Client
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation2 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblResult = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.loginConfirm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logInTab = new System.Windows.Forms.Panel();
            this.nameCatch = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.numCatch = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.numTxt = new System.Windows.Forms.RichTextBox();
            this.nameTxt = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.signUpConfirm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.signUpTab = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.signUpNameTxt = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.signUpNumTxt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.signUp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.logInTab.SuspendLayout();
            this.signUpTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.animator1.SetDecoration(this.lblResult, AnimatorNS.DecorationType.None);
            this.lblResult.Location = new System.Drawing.Point(208, 189);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 6;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // loginConfirm
            // 
            this.loginConfirm.Activecolor = System.Drawing.Color.Silver;
            this.loginConfirm.BackColor = System.Drawing.Color.Gainsboro;
            this.loginConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginConfirm.BorderRadius = 0;
            this.loginConfirm.ButtonText = "Log In";
            this.loginConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.loginConfirm, AnimatorNS.DecorationType.None);
            this.loginConfirm.DisabledColor = System.Drawing.Color.Gray;
            this.loginConfirm.Iconcolor = System.Drawing.Color.Transparent;
            this.loginConfirm.Iconimage = null;
            this.loginConfirm.Iconimage_right = null;
            this.loginConfirm.Iconimage_right_Selected = null;
            this.loginConfirm.Iconimage_Selected = null;
            this.loginConfirm.IconMarginLeft = 0;
            this.loginConfirm.IconMarginRight = 0;
            this.loginConfirm.IconRightVisible = true;
            this.loginConfirm.IconRightZoom = 0D;
            this.loginConfirm.IconVisible = true;
            this.loginConfirm.IconZoom = 90D;
            this.loginConfirm.IsTab = false;
            this.loginConfirm.Location = new System.Drawing.Point(81, 408);
            this.loginConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginConfirm.Name = "loginConfirm";
            this.loginConfirm.Normalcolor = System.Drawing.Color.Gainsboro;
            this.loginConfirm.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.loginConfirm.OnHoverTextColor = System.Drawing.Color.White;
            this.loginConfirm.selected = false;
            this.loginConfirm.Size = new System.Drawing.Size(381, 53);
            this.loginConfirm.TabIndex = 10;
            this.loginConfirm.Text = "Log In";
            this.loginConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginConfirm.Textcolor = System.Drawing.Color.Black;
            this.loginConfirm.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginConfirm.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // logInTab
            // 
            this.logInTab.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.logInTab.Controls.Add(this.nameCatch);
            this.logInTab.Controls.Add(this.numCatch);
            this.logInTab.Controls.Add(this.bunifuSeparator1);
            this.logInTab.Controls.Add(this.numTxt);
            this.logInTab.Controls.Add(this.nameTxt);
            this.logInTab.Controls.Add(this.bunifuCustomLabel3);
            this.logInTab.Controls.Add(this.bunifuCustomLabel2);
            this.logInTab.Controls.Add(this.bunifuCustomLabel1);
            this.logInTab.Controls.Add(this.lblResult);
            this.animator1.SetDecoration(this.logInTab, AnimatorNS.DecorationType.None);
            this.logInTab.Location = new System.Drawing.Point(81, 105);
            this.logInTab.Name = "logInTab";
            this.logInTab.Size = new System.Drawing.Size(381, 296);
            this.logInTab.TabIndex = 13;
            this.logInTab.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // nameCatch
            // 
            this.nameCatch.AutoSize = true;
            this.animator1.SetDecoration(this.nameCatch, AnimatorNS.DecorationType.None);
            this.nameCatch.ForeColor = System.Drawing.Color.Crimson;
            this.nameCatch.Location = new System.Drawing.Point(29, 161);
            this.nameCatch.Name = "nameCatch";
            this.nameCatch.Size = new System.Drawing.Size(200, 17);
            this.nameCatch.TabIndex = 21;
            this.nameCatch.Text = "*Name only can contain letters";
            this.nameCatch.Visible = false;
            // 
            // numCatch
            // 
            this.numCatch.AutoSize = true;
            this.animator1.SetDecoration(this.numCatch, AnimatorNS.DecorationType.None);
            this.numCatch.ForeColor = System.Drawing.Color.Crimson;
            this.numCatch.Location = new System.Drawing.Point(29, 269);
            this.numCatch.Name = "numCatch";
            this.numCatch.Size = new System.Drawing.Size(229, 17);
            this.numCatch.TabIndex = 20;
            this.numCatch.Text = "*Number can only contain numbers";
            this.numCatch.Visible = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuSeparator1, AnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, -20);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(108, 43);
            this.bunifuSeparator1.TabIndex = 19;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // numTxt
            // 
            this.numTxt.BackColor = System.Drawing.Color.DimGray;
            this.numTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animator1.SetDecoration(this.numTxt, AnimatorNS.DecorationType.None);
            this.numTxt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numTxt.Location = new System.Drawing.Point(32, 224);
            this.numTxt.Name = "numTxt";
            this.numTxt.Size = new System.Drawing.Size(322, 42);
            this.numTxt.TabIndex = 13;
            this.numTxt.Text = "";
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.DimGray;
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animator1.SetDecoration(this.nameTxt, AnimatorNS.DecorationType.None);
            this.nameTxt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameTxt.Location = new System.Drawing.Point(32, 114);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(322, 44);
            this.nameTxt.TabIndex = 12;
            this.nameTxt.Text = "";
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel3, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(28, 199);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(64, 19);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "Number";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel2, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(28, 89);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(51, 19);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Name";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel1, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(109, 21);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(139, 49);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Log In";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // signUpConfirm
            // 
            this.signUpConfirm.Activecolor = System.Drawing.Color.Silver;
            this.signUpConfirm.BackColor = System.Drawing.Color.Gainsboro;
            this.signUpConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signUpConfirm.BorderRadius = 0;
            this.signUpConfirm.ButtonText = "Sign Up";
            this.signUpConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.signUpConfirm, AnimatorNS.DecorationType.None);
            this.signUpConfirm.DisabledColor = System.Drawing.Color.Gray;
            this.signUpConfirm.Iconcolor = System.Drawing.Color.Transparent;
            this.signUpConfirm.Iconimage = null;
            this.signUpConfirm.Iconimage_right = null;
            this.signUpConfirm.Iconimage_right_Selected = null;
            this.signUpConfirm.Iconimage_Selected = null;
            this.signUpConfirm.IconMarginLeft = 0;
            this.signUpConfirm.IconMarginRight = 0;
            this.signUpConfirm.IconRightVisible = true;
            this.signUpConfirm.IconRightZoom = 0D;
            this.signUpConfirm.IconVisible = true;
            this.signUpConfirm.IconZoom = 90D;
            this.signUpConfirm.IsTab = false;
            this.signUpConfirm.Location = new System.Drawing.Point(560, 408);
            this.signUpConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUpConfirm.Name = "signUpConfirm";
            this.signUpConfirm.Normalcolor = System.Drawing.Color.Gainsboro;
            this.signUpConfirm.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.signUpConfirm.OnHoverTextColor = System.Drawing.Color.White;
            this.signUpConfirm.selected = false;
            this.signUpConfirm.Size = new System.Drawing.Size(383, 53);
            this.signUpConfirm.TabIndex = 15;
            this.signUpConfirm.Text = "Sign Up";
            this.signUpConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpConfirm.Textcolor = System.Drawing.Color.Black;
            this.signUpConfirm.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpConfirm.Click += new System.EventHandler(this.signUpConfirm_Click);
            // 
            // signUpTab
            // 
            this.signUpTab.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.signUpTab.Controls.Add(this.bunifuCustomLabel8);
            this.signUpTab.Controls.Add(this.bunifuCustomLabel7);
            this.signUpTab.Controls.Add(this.richTextBox2);
            this.signUpTab.Controls.Add(this.signUpNameTxt);
            this.signUpTab.Controls.Add(this.bunifuCustomLabel4);
            this.signUpTab.Controls.Add(this.bunifuCustomLabel5);
            this.signUpTab.Controls.Add(this.bunifuCustomLabel6);
            this.signUpTab.Controls.Add(this.label1);
            this.animator1.SetDecoration(this.signUpTab, AnimatorNS.DecorationType.None);
            this.signUpTab.Location = new System.Drawing.Point(560, 105);
            this.signUpTab.Name = "signUpTab";
            this.signUpTab.Size = new System.Drawing.Size(383, 301);
            this.signUpTab.TabIndex = 16;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel8, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Crimson;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(29, 279);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(229, 17);
            this.bunifuCustomLabel8.TabIndex = 22;
            this.bunifuCustomLabel8.Text = "*Number can only contain numbers";
            this.bunifuCustomLabel8.Visible = false;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel7, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Crimson;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(29, 172);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(200, 17);
            this.bunifuCustomLabel7.TabIndex = 22;
            this.bunifuCustomLabel7.Text = "*Name only can contain letters";
            this.bunifuCustomLabel7.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.DimGray;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animator1.SetDecoration(this.richTextBox2, AnimatorNS.DecorationType.None);
            this.richTextBox2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox2.Location = new System.Drawing.Point(32, 224);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(322, 56);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // signUpNameTxt
            // 
            this.signUpNameTxt.BackColor = System.Drawing.Color.DimGray;
            this.signUpNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animator1.SetDecoration(this.signUpNameTxt, AnimatorNS.DecorationType.None);
            this.signUpNameTxt.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpNameTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.signUpNameTxt.Location = new System.Drawing.Point(32, 113);
            this.signUpNameTxt.Name = "signUpNameTxt";
            this.signUpNameTxt.Size = new System.Drawing.Size(322, 56);
            this.signUpNameTxt.TabIndex = 13;
            this.signUpNameTxt.Text = "";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel4, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(28, 199);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(64, 19);
            this.bunifuCustomLabel4.TabIndex = 11;
            this.bunifuCustomLabel4.Text = "Number";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel5, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(28, 89);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(51, 19);
            this.bunifuCustomLabel5.TabIndex = 10;
            this.bunifuCustomLabel5.Text = "Name";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel6, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(110, 21);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(164, 49);
            this.bunifuCustomLabel6.TabIndex = 0;
            this.bunifuCustomLabel6.Text = "Sign up";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animator1.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(208, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.animator1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation2;
            // 
            // signUpNumTxt
            // 
            this.signUpNumTxt.Activecolor = System.Drawing.Color.Silver;
            this.signUpNumTxt.BackColor = System.Drawing.Color.Gainsboro;
            this.signUpNumTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signUpNumTxt.BorderRadius = 0;
            this.signUpNumTxt.ButtonText = "Log In";
            this.signUpNumTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.signUpNumTxt, AnimatorNS.DecorationType.None);
            this.signUpNumTxt.DisabledColor = System.Drawing.Color.Gray;
            this.signUpNumTxt.Iconcolor = System.Drawing.Color.Transparent;
            this.signUpNumTxt.Iconimage = null;
            this.signUpNumTxt.Iconimage_right = null;
            this.signUpNumTxt.Iconimage_right_Selected = null;
            this.signUpNumTxt.Iconimage_Selected = null;
            this.signUpNumTxt.IconMarginLeft = 0;
            this.signUpNumTxt.IconMarginRight = 0;
            this.signUpNumTxt.IconRightVisible = true;
            this.signUpNumTxt.IconRightZoom = 0D;
            this.signUpNumTxt.IconVisible = true;
            this.signUpNumTxt.IconZoom = 90D;
            this.signUpNumTxt.IsTab = false;
            this.signUpNumTxt.Location = new System.Drawing.Point(308, 13);
            this.signUpNumTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUpNumTxt.Name = "signUpNumTxt";
            this.signUpNumTxt.Normalcolor = System.Drawing.Color.Gainsboro;
            this.signUpNumTxt.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.signUpNumTxt.OnHoverTextColor = System.Drawing.Color.White;
            this.signUpNumTxt.selected = false;
            this.signUpNumTxt.Size = new System.Drawing.Size(154, 69);
            this.signUpNumTxt.TabIndex = 17;
            this.signUpNumTxt.Text = "Log In";
            this.signUpNumTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUpNumTxt.Textcolor = System.Drawing.Color.Black;
            this.signUpNumTxt.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpNumTxt.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // signUp
            // 
            this.signUp.Activecolor = System.Drawing.Color.Silver;
            this.signUp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.signUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signUp.BorderRadius = 1;
            this.signUp.ButtonText = "Sign up";
            this.signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.signUp, AnimatorNS.DecorationType.None);
            this.signUp.DisabledColor = System.Drawing.Color.Gray;
            this.signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.Iconcolor = System.Drawing.Color.Transparent;
            this.signUp.Iconimage = null;
            this.signUp.Iconimage_right = null;
            this.signUp.Iconimage_right_Selected = null;
            this.signUp.Iconimage_Selected = null;
            this.signUp.IconMarginLeft = 0;
            this.signUp.IconMarginRight = 0;
            this.signUp.IconRightVisible = true;
            this.signUp.IconRightZoom = 0D;
            this.signUp.IconVisible = true;
            this.signUp.IconZoom = 90D;
            this.signUp.IsTab = false;
            this.signUp.Location = new System.Drawing.Point(81, 13);
            this.signUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUp.Name = "signUp";
            this.signUp.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.signUp.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.signUp.OnHoverTextColor = System.Drawing.Color.White;
            this.signUp.selected = false;
            this.signUp.Size = new System.Drawing.Size(150, 69);
            this.signUp.TabIndex = 18;
            this.signUp.Text = "Sign up";
            this.signUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signUp.Textcolor = System.Drawing.Color.Black;
            this.signUp.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuSeparator2, AnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuSeparator2.LineThickness = 4;
            this.bunifuSeparator2.Location = new System.Drawing.Point(308, 85);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(154, 10);
            this.bunifuSeparator2.TabIndex = 19;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(534, 498);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.signUpNumTxt);
            this.Controls.Add(this.signUpConfirm);
            this.Controls.Add(this.signUpTab);
            this.Controls.Add(this.loginConfirm);
            this.Controls.Add(this.logInTab);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.Text = "Client Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.logInTab.ResumeLayout(false);
            this.logInTab.PerformLayout();
            this.signUpTab.ResumeLayout(false);
            this.signUpTab.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lblResult;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton loginConfirm;
        private System.Windows.Forms.Panel logInTab;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton signUpConfirm;
        private System.Windows.Forms.Panel signUpTab;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private AnimatorNS.Animator animator1;
        private Bunifu.Framework.UI.BunifuFlatButton signUp;
        private Bunifu.Framework.UI.BunifuFlatButton signUpNumTxt;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox signUpNameTxt;
        private System.Windows.Forms.RichTextBox numTxt;
        private System.Windows.Forms.RichTextBox nameTxt;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel nameCatch;
        private Bunifu.Framework.UI.BunifuCustomLabel numCatch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
    }
}