namespace Server
{
    partial class Form2
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
            this.txtChat = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNoOfConnections = new System.Windows.Forms.Label();
            this.ddlActives = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(9, 78);
            this.txtChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(1094, 415);
            this.txtChat.TabIndex = 0;
            this.txtChat.Text = "";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(11, 508);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(846, 56);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "";
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(868, 518);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(101, 34);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(992, 518);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(957, 19);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(101, 34);
            this.btnSendFile.TabIndex = 5;
            this.btnSendFile.Text = "Send File";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(989, 55);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(70, 20);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "lblResult";
            this.lblResult.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Active Connections : ";
            // 
            // lblNoOfConnections
            // 
            this.lblNoOfConnections.AutoSize = true;
            this.lblNoOfConnections.Location = new System.Drawing.Point(166, 19);
            this.lblNoOfConnections.Name = "lblNoOfConnections";
            this.lblNoOfConnections.Size = new System.Drawing.Size(18, 20);
            this.lblNoOfConnections.TabIndex = 9;
            this.lblNoOfConnections.Text = "0";
            // 
            // ddlActives
            // 
            this.ddlActives.FormattingEnabled = true;
            this.ddlActives.Location = new System.Drawing.Point(660, 19);
            this.ddlActives.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlActives.Name = "ddlActives";
            this.ddlActives.Size = new System.Drawing.Size(284, 28);
            this.ddlActives.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Send To :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 576);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlActives);
            this.Controls.Add(this.lblNoOfConnections);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtChat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "EEGARAJE Server";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNoOfConnections;
        private System.Windows.Forms.ComboBox ddlActives;
        private System.Windows.Forms.Label label2;
    }
}