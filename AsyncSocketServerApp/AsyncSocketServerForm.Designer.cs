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
            this.SendAll = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AcceptConnection
            // 
            this.AcceptConnection.AutoSize = true;
            this.AcceptConnection.Location = new System.Drawing.Point(13, 24);
            this.AcceptConnection.Name = "AcceptConnection";
            this.AcceptConnection.Size = new System.Drawing.Size(259, 23);
            this.AcceptConnection.TabIndex = 0;
            this.AcceptConnection.Text = "Accept Incomming Connection";
            this.AcceptConnection.UseVisualStyleBackColor = true;
            this.AcceptConnection.Click += new System.EventHandler(this.AcceptConnection_Click);
            // 
            // SendAll
            // 
            this.SendAll.AutoSize = true;
            this.SendAll.Location = new System.Drawing.Point(197, 162);
            this.SendAll.Name = "SendAll";
            this.SendAll.Size = new System.Drawing.Size(75, 23);
            this.SendAll.TabIndex = 1;
            this.SendAll.Text = "Send To All";
            this.SendAll.UseVisualStyleBackColor = true;
            this.SendAll.Click += new System.EventHandler(this.SendAll_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(13, 82);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(259, 74);
            this.txtMessage.TabIndex = 2;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(13, 63);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 3;
            this.labelMessage.Text = "Message";
            // 
            // AsyncServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 215);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.SendAll);
            this.Controls.Add(this.AcceptConnection);
            this.Name = "AsyncServerForm";
            this.Text = "Server: Async Socket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptConnection;
        private System.Windows.Forms.Button SendAll;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label labelMessage;
    }
}

