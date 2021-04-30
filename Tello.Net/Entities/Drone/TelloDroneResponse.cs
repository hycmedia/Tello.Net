using System;
namespace Tello.Net.Entities.Drone
{
    public class TelloDroneResponse : IDroneResponse
    {
        public string Message { get; set; }

        public bool IsSuccessfull()
        {
            return Message.Equals("ok");
        }
    }
}
