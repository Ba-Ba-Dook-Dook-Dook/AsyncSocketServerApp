using System;

namespace AsyncSocketServerApp
{
    partial class AsyncServerForm
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
            this.AcceptConnection = new System.Windows.Forms.Button();
            this.pnlMessages = new System.Windows.Forms.Panel();
            this.txtClients = new System.Windows.Forms.TextBox();
            this.StopServer = new System.Windows.Forms.Button();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SendAll = new System.Windows.Forms.Button();
            this.pnlMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcceptConnection
            // 
            this.AcceptConnection.AutoSize = true;
            this.AcceptConnection.Location = new System.Drawing.Point(12, 73);
            this.AcceptConnection.Name = "AcceptConnection";
            this.AcceptConnection.Size = new System.Drawing.Size(263, 23);
            this.AcceptConnection.TabIndex = 0;
            this.AcceptConnection.Text = "Accept Incomming Connection";
            this.AcceptConnection.UseVisualStyleBackColor = true;
            this.AcceptConnection.Click += new System.EventHandler(this.AcceptConnection_Click);
            // 
            // pnlMessages
            // 
            this.pnlMessages.AutoSize = true;
            this.pnlMessages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMessages.Controls.Add(this.labelMessage);
            this.pnlMessages.Controls.Add(this.txtMessage);
            this.pnlMessages.Controls.Add(this.SendAll);
            this.pnlMessages.Controls.Add(this.txtClients);
            this.pnlMessages.Location = new System.Drawing.Point(12, 150);
            this.pnlMessages.Name = "pnlMessages";
            this.pnlMessages.Size = new System.Drawing.Size(884, 224);
            this.pnlMessages.TabIndex = 4;
            this.pnlMessages.Visible = false;
            // 
            // txtClients
            // 
            this.txtClients.Location = new System.Drawing.Point(8, 3);
            this.txtClients.Multiline = true;
            this.txtClients.Name = "txtClients";
            this.txtClients.Size = new System.Drawing.Size(873, 157);
            this.txtClients.TabIndex = 7;
            // 
            // StopServer
            // 
            this.StopServer.AutoSize = true;
            this.StopServer.Location = new System.Drawing.Point(12, 112);
            this.StopServer.Name = "StopServer";
            this.StopServer.Size = new System.Drawing.Size(263, 23);
            this.StopServer.TabIndex = 5;
            this.StopServer.Text = "Stop Server";
            this.StopServer.UseVisualStyleBackColor = true;
            this.StopServer.Click += new System.EventHandler(this.StopServer_Click);
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerStatus.Location = new System.Drawing.Point(12, 9);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(185, 46);
            this.lblServerStatus.TabIndex = 6;
            this.lblServerStatus.Text = "Initialized";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(16, 179);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 10;
            this.labelMessage.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(16, 198);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(784, 23);
            this.txtMessage.TabIndex = 9;
            // 
            // SendAll
            // 
            this.SendAll.AutoSize = true;
            this.SendAll.Location = new System.Drawing.Point(806, 196);
            this.SendAll.Name = "SendAll";
            this.SendAll.Size = new System.Drawing.Size(75, 23);
            this.SendAll.TabIndex = 8;
            this.SendAll.Text = "Send To All";
            this.SendAll.UseVisualStyleBackColor = true;
            this.SendAll.Click += new EventHandler(this.SendAll_Click);
            // 
            // AsyncServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 493);
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.StopServer);
            this.Controls.Add(this.pnlMessages);
            this.Controls.Add(this.AcceptConnection);
            this.Name = "AsyncServerForm";
            this.Text = "Server: Async Socket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AsyncServerForm_FormClosing);
            this.pnlMessages.ResumeLayout(false);
            this.pnlMessages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptConnection;
        private System.Windows.Forms.Panel pnlMessages;
        private System.Windows.Forms.Button StopServer;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.TextBox txtClients;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button SendAll;
    }
}

