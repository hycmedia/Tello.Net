using System;
using Tello.Net.Entities.Connection;
using Tello.Net.Entities.ControlCommand;

namespace Tello.Net.Entities.Drone
{
    public interface IDrone<T>
    {
        public T SendCommand(Command command);

        public delegate void ResponseCallback(IDroneResponse response);

        public T WaitForResponse(ResponseCallback response);
    }
}
