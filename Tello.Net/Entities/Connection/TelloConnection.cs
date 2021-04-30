using System;
using System.Net.Sockets;
using System.Text;

namespace Tello.Net.Entities.Connection
{
    public class TelloConnection : IConnection
    {
        public bool Connected
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public string IpAddress
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public UdpClient UdpClient { get; set; }

        public void Connect(string ipAddress, int port)
        {
            this.UdpClient = new UdpClient(ipAddress, port);
        }

        public void Disconnect()
        {
            this.UdpClient.Dispose();
        }
    }
}
