using System;
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

        }
    }
}
