namespace WK7_QTN2_Client
{
    partial class ClientGUI
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
            this.clientChatBox = new System.Windows.Forms.RichTextBox();
            this.clientTxt = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clientText = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.resultFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientChatBox
            // 
            this.clientChatBox.Location = new System.Drawing.Point(0, 88);
            this.clientChatBox.Name = "clientChatBox";
            this.clientChatBox.Size = new System.Drawing.Size(1126, 336);
            this.clientChatBox.TabIndex = 0;
            this.clientChatBox.Text = "";
            // 
            // clientTxt
            // 
            this.clientTxt.Location = new System.Drawing.Point(12, 440);
            this.clientTxt.Name = "clientTxt";
            this.clientTxt.Size = new System.Drawing.Size(829, 49);
            this.clientTxt.TabIndex = 1;
            this.clientTxt.Text = "";
            this.clientTxt.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(786, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Send File";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // clientText
            // 
            this.clientText.Location = new System.Drawing.Point(520, 27);
            this.clientText.Name = "clientText";
            this.clientText.Size = new System.Drawing.Size(236, 30);
            this.clientText.TabIndex = 5;
            this.clientText.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1005, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Quit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(901, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Get File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // resultFile
            // 
            this.resultFile.AutoSize = true;
            this.resultFile.Location = new System.Drawing.Point(1017, 33);
            this.resultFile.Name = "resultFile";
            this.resultFile.Size = new System.Drawing.Size(43, 17);
            this.resultFile.TabIndex = 8;
            this.resultFile.Text = "result";
            this.resultFile.Visible = false;
            // 
            // ClientGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 497);
            this.Controls.Add(this.resultFile);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.clientText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientTxt);
            this.Controls.Add(this.clientChatBox);
            this.Name = "ClientGUI";
            this.Text = "ClientGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox clientChatBox;
        private System.Windows.Forms.RichTextBox clientTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox clientText;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label resultFile;
    }
}