using System;
namespace Tello.Net.Entities.Connection
{
    public interface IConnection
    {
        public bool Connected { get; set; }

        public string IpAddress { get; set; }

        public void Connect(string ipAddress, int port);

        public void Disconnect();
    }
}
