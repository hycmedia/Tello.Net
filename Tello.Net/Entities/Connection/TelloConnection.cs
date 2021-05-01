using System;
using System.Net.Sockets;
using System.Text;

namespace Tello.Net.Entities.Connection
{
    public class TelloConnection : IConnection
    {
        public bool Connected
        {
            get;
            set;
        }

        public string IpAddress
        {
            get;
            set;
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
