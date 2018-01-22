namespace WK7_QTN2_Client
{
    partial class ChatApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatApplication));
            this.nameOnline = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sendV2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.clientTxtv2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chat = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.speakV2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.stopV2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkAllV2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.openDialogV2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sendV2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speakV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openDialogV2)).BeginInit();
            this.bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameOnline
            // 
            this.nameOnline.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOnline.ForeColor = System.Drawing.Color.DimGray;
            this.nameOnline.Location = new System.Drawing.Point(12, 8);
            this.nameOnline.Name = "nameOnline";
            this.nameOnline.Size = new System.Drawing.Size(736, 37);
            this.nameOnline.TabIndex = 10;
            this.nameOnline.Click += new System.EventHandler(this.lblHello_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sendV2
            // 
            this.sendV2.BackColor = System.Drawing.Color.Transparent;
            this.sendV2.Image = ((System.Drawing.Image)(resources.GetObject("sendV2.Image")));
            this.sendV2.ImageActive = null;
            this.sendV2.Location = new System.Drawing.Point(846, 48);
            this.sendV2.Name = "sendV2";
            this.sendV2.Size = new System.Drawing.Size(47, 41);
            this.sendV2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sendV2.TabIndex = 1;
            this.sendV2.TabStop = false;
            this.sendV2.Zoom = 10;
            this.sendV2.Click += new System.EventHandler(this.sendConfirm_Click);
            // 
            // clientTxtv2
            // 
            this.clientTxtv2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientTxtv2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.clientTxtv2.ForeColor = System.Drawing.Color.Black;
            this.clientTxtv2.HintForeColor = System.Drawing.Color.Transparent;
            this.clientTxtv2.HintText = "";
            this.clientTxtv2.isPassword = false;
            this.clientTxtv2.LineFocusedColor = System.Drawing.Color.Black;
            this.clientTxtv2.LineIdleColor = System.Drawing.Color.Gray;
            this.clientTxtv2.LineMouseHoverColor = System.Drawing.Color.Black;
            this.clientTxtv2.LineThickness = 3;
            this.clientTxtv2.Location = new System.Drawing.Point(-1, 44);
            this.clientTxtv2.Margin = new System.Windows.Forms.Padding(4);
            this.clientTxtv2.Name = "clientTxtv2";
            this.clientTxtv2.Size = new System.Drawing.Size(776, 46);
            this.clientTxtv2.TabIndex = 0;
            this.clientTxtv2.Text = "Send Message";
            this.clientTxtv2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.clientTxtv2.OnValueChanged += new System.EventHandler(this.clientTxtv2_OnValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chat);
            this.panel1.Controls.Add(this.nameOnline);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 626);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chat
            // 
            this.chat.BackColor = System.Drawing.Color.White;
            this.chat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chat.ForeColor = System.Drawing.Color.Black;
            this.chat.Image = ((System.Drawing.Image)(resources.GetObject("chat.Image")));
            this.chat.Location = new System.Drawing.Point(3, 57);
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(1001, 471);
            this.chat.TabIndex = 14;
            this.chat.Click += new System.EventHandler(this.chat_Click);
            // 
            // speakV2
            // 
            this.speakV2.BackColor = System.Drawing.Color.Transparent;
            this.speakV2.Image = ((System.Drawing.Image)(resources.GetObject("speakV2.Image")));
            this.speakV2.ImageActive = ((System.Drawing.Image)(resources.GetObject("speakV2.ImageActive")));
            this.speakV2.Location = new System.Drawing.Point(900, 48);
            this.speakV2.Name = "speakV2";
            this.speakV2.Size = new System.Drawing.Size(47, 41);
            this.speakV2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.speakV2.TabIndex = 16;
            this.speakV2.TabStop = false;
            this.speakV2.Zoom = 10;
            this.speakV2.Click += new System.EventHandler(this.speakV2_Click);
            // 
            // stopV2
            // 
            this.stopV2.BackColor = System.Drawing.Color.Transparent;
            this.stopV2.Image = ((System.Drawing.Image)(resources.GetObject("stopV2.Image")));
            this.stopV2.ImageActive = ((System.Drawing.Image)(resources.GetObject("stopV2.ImageActive")));
            this.stopV2.Location = new System.Drawing.Point(953, 48);
            this.stopV2.Name = "stopV2";
            this.stopV2.Size = new System.Drawing.Size(47, 41);
            this.stopV2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stopV2.TabIndex = 17;
            this.stopV2.TabStop = false;
            this.stopV2.Zoom = 10;
            this.stopV2.Click += new System.EventHandler(this.stopV2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(789, 16);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(149, 30);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Send To All ";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAllV2
            // 
            this.chkAllV2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkAllV2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkAllV2.Checked = false;
            this.chkAllV2.CheckedOnColor = System.Drawing.Color.Gray;
            this.chkAllV2.ForeColor = System.Drawing.Color.White;
            this.chkAllV2.Location = new System.Drawing.Point(936, 21);
            this.chkAllV2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAllV2.Name = "chkAllV2";
            this.chkAllV2.Size = new System.Drawing.Size(20, 20);
            this.chkAllV2.TabIndex = 7;
            // 
            // openDialogV2
            // 
            this.openDialogV2.BackColor = System.Drawing.Color.Transparent;
            this.openDialogV2.Image = ((System.Drawing.Image)(resources.GetObject("openDialogV2.Image")));
            this.openDialogV2.ImageActive = null;
            this.openDialogV2.Location = new System.Drawing.Point(793, 48);
            this.openDialogV2.Name = "openDialogV2";
            this.openDialogV2.Size = new System.Drawing.Size(47, 41);
            this.openDialogV2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openDialogV2.TabIndex = 18;
            this.openDialogV2.TabStop = false;
            this.openDialogV2.Zoom = 10;
            this.openDialogV2.Click += new System.EventHandler(this.openDialogV2_Click);
            // 
            // bottom
            // 
            this.bottom.Controls.Add(this.openDialogV2);
            this.bottom.Controls.Add(this.chkAllV2);
            this.bottom.Controls.Add(this.bunifuCustomLabel1);
            this.bottom.Controls.Add(this.stopV2);
            this.bottom.Controls.Add(this.sendV2);
            this.bottom.Controls.Add(this.speakV2);
            this.bottom.Controls.Add(this.clientTxtv2);
            this.bottom.Location = new System.Drawing.Point(0, 525);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(1279, 102);
            this.bottom.TabIndex = 14;
            // 
            // ChatApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 624);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ChatApplication";
            this.Text = "ClientGUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.getFile_FormClosed);
            this.Load += new System.EventHandler(this.ClientGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sendV2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speakV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openDialogV2)).EndInit();
            this.bottom.ResumeLayout(false);
            this.bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label nameOnline;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton sendV2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox clientTxtv2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton stopV2;
        private Bunifu.Framework.UI.BunifuImageButton speakV2;
        private Bunifu.Framework.UI.BunifuCheckbox chkAllV2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton openDialogV2;
        private Bunifu.Framework.UI.BunifuCustomLabel chat;
        private System.Windows.Forms.Panel bottom;
    }
}