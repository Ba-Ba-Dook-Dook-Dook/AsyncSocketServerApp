using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace AsyncSocketLib
{
    public class AsyncSocketServer
    {
        private IPAddress _ipAddress;
        private int _port;
        private TcpListener _tcpListener;
        private List<TcpClient> _tcpClients;

        public EventHandler<ClientConnetedEventArgs> RaiseClienteConnectedEvent;
        public EventHandler<MessageReceivedEventArgs> RaiseMessageReceivedEvent;

        public bool KeepRunning { get; set; }

        public AsyncSocketServer()
        {
            _tcpClients = new List<TcpClient>();
        }

        public async void StartListeningForIncomingConnection(IPAddress ipAddress = null, int port = 23000)
        {
            if (ipAddress == null)
                ipAddress = IPAddress.Any;

            if (port <= 0)
                port = 23000;

            _ipAddress = ipAddress;
            _port = port;

            Debug.WriteLine($"IP Address: {_ipAddress} - Port: {_port}.");

            _tcpListener = new TcpListener(_ipAddress, _port);

            try
            {
                _tcpListener.Start();

                KeepRunning = true;

                while (KeepRunning)
                {
                    var returnedByAccept = await _tcpListener.AcceptTcpClientAsync();

                    _tcpClients.Add(returnedByAccept);

                    Debug.WriteLine($"Client connected successfully, count: {_tcpClients.Count} - {returnedByAccept.Client.RemoteEndPoint}.");

                    TakeCareOfTcpClient(returnedByAccept);

                    var eClientConnected = new ClientConnetedEventArgs(returnedByAccept.Client.RemoteEndPoint.ToString());

                    OnRaiseClienteConnectedEvent(eClientConnected);

                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

        }

        private async void TakeCareOfTcpClient(TcpClient tcpClient)
        {
            try
            {
                var networkStream = tcpClient.GetStream();
                var streamReader = new StreamReader(networkStream);

                var buff = new char[64];

                while (KeepRunning)
                {
                    Debug.WriteLine("*** Ready to read.");

                    var nRet = await streamReader.ReadAsync(buff, 0, buff.Length);

                    Debug.WriteLine($"Returned: {nRet}");

                    if (nRet == 0)
                    {
                        RemoveClient(tcpClient);
                        Debug.WriteLine("Socket disconnected.");
                        break;
                    }

                    var receivedText = new string(buff);

                    Debug.WriteLine($"*** RECEIVED: {receivedText}.");

                    OnRaiseMessageReceivedEvent(new MessageReceivedEventArgs(tcpClient.Client.RemoteEndPoint.ToString(), receivedText));

                    Array.Clear(buff, 0, buff.Length);

                }

            }
            catch (Exception exception)
            {
                RemoveClient(tcpClient);
                Console.WriteLine(exception);

            }
        }

        private void RemoveClient(TcpClient tcpClient)
        {
            if (_tcpClients.Contains(tcpClient))
            {
                _tcpClients.Remove(tcpClient);
                Debug.WriteLine($"Client removed, count: {_tcpClients.Count}");
            }
        }

        public void SendToAll(string message)
        {
            if (string.IsNullOrEmpty(message))
                return;

            try
            {
                var buffMessage = Encoding.ASCII.GetBytes(message);

                foreach (var tcpClient in _tcpClients)
                    tcpClient.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public void StopServer()
        {
            try
            {
                _tcpListener?.Stop();

                if (_tcpClients == null) return;

                foreach (var tcpClient in _tcpClients)
                    tcpClient.Close();

                _tcpClients.Clear();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        protected void OnRaiseClienteConnectedEvent(ClientConnetedEventArgs e)
        {
            var handler = RaiseClienteConnectedEvent;

            handler?.Invoke(this, e);
        }

        protected void OnRaiseMessageReceivedEvent(MessageReceivedEventArgs e)
        {
            var handler = RaiseMessageReceivedEvent;

            handler?.Invoke(this, e);
        }
    }
}
