using System;
using System.Drawing;
using System.Windows.Forms;
using AsyncSocketLib;

namespace AsyncSocketServerApp
{
    public partial class AsyncServerForm : Form
    {
        private readonly AsyncSocketServer _asyncSocketServer;

        public AsyncServerForm()
        {
            InitializeComponent();
            _asyncSocketServer = new AsyncSocketServer();
        }

        private void AcceptConnection_Click(object sender, EventArgs e)
        {

            _asyncSocketServer.StartListeningForIncomingConnection();

            if (lblServerStatus == null) return;

            lblServerStatus.Text = @"Listening...";
            lblServerStatus.BackColor = Color.Green;
            lblServerStatus.ForeColor = Color.White;

            pnlMessages.Visible = true;
        }

        private void SendAll_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMessage?.Text))
                _asyncSocketServer?.SendToAll(txtMessage.Text.Trim());
        }

        private void StopServer_Click(object sender, EventArgs e)
        {
            _asyncSocketServer.StopServer();

            if (lblServerStatus == null) return;

            lblServerStatus.Text = @"Stopped!";
            lblServerStatus.BackColor = Color.Red;
            lblServerStatus.ForeColor = Color.White;

            pnlMessages.Visible = false;

        }

        private void AsyncServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _asyncSocketServer?.StopServer();
        }

    }
}
