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
            var commandBytes = Encoding.ASCII.GetBytes(command.Name);
            this.Connection.UdpClient.Send(commandBytes, commandBytes.Length);

            return this;
        }

        public void EnableSdk()
        {
            this.SendCommand(new SdkCommand());
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
