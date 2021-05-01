using System;
using System.Net.Sockets;

namespace Tello.Net.Manager
{
    public class CommandListeningManager
    {
        public UdpClient UdpClient { get; set; }

        public CommandListeningManager()
        {
            this.UdpClient = new UdpClient();
        }
    }
}
