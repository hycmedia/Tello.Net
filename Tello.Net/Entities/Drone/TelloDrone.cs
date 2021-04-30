using System;
using System.Text;
using System.Threading;
using Tello.Net.Entities.Connection;
using Tello.Net.Entities.ControlCommand;

namespace Tello.Net.Entities.Drone
{
    public class TelloDrone : IDrone<TelloDrone>
    {
        public TelloConnection Connection { get; set; }

        public TelloDrone(TelloConnection connection)
        {
            this.Connection = connection;
        }      

        public TelloDrone SendCommand(Command command)
        {
            this.EnableSdk();
            this.SendString(command.Name);

            return this;
        }

        private void SendString(string text)
        {
            var commandBytes = Encoding.ASCII.GetBytes(text);
            this.Connection.UdpClient.Send(commandBytes, commandBytes.Length);
        }

        public void EnableSdk()
        {
            this.SendString(new SdkCommand().Name);
        }

        public TelloDrone Wait(int milliseconds)
        {
            Thread.Sleep(milliseconds);

            return this;
        }

        public TelloDrone WaitForResponse(IDrone<TelloDrone>.ResponseCallback response)
        {
            throw new NotImplementedException();
        }
    }
}
