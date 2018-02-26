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

            if (!(sender is Button button)) return;

            button.BackColor = Color.Green;
            button.ForeColor = Color.White;
            
        }

        private void SendAll_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMessage?.Text))
                _asyncSocketServer?.SendToAll(txtMessage.Text.Trim());
        }
    }
}
