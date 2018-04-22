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
            _asyncSocketServer.RaiseClienteConnectedEvent += HandleClientConnected;
            _asyncSocketServer.RaiseMessageReceivedEvent += HandleMessageReceived;
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

        private void HandleClientConnected(object sender, ClientConnetedEventArgs clientConnetedEventArgs)
        {
            txtClients.AppendText($"{DateTime.Now} - New client connected: {clientConnetedEventArgs.NewClient}{Environment.NewLine}");
        }

        public void HandleMessageReceived(object sender, MessageReceivedEventArgs e)
        {
            if (e.Client == null) return;

            if (e.MessageReceived != null)
                txtMessage.AppendText($"{DateTime.Now} - Received from {e.Client} : {e.MessageReceived} {Environment.NewLine}");
        }

    }
}
