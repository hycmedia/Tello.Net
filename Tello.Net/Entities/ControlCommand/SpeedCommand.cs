using System;
namespace Tello.Net.Entities.ControlCommand
{
    public class SpeedCommand : Command
    {
        public override string Name { get; set; } = "speed";

        public SpeedCommand(int speed) : base(speed)
        {
        }
    }
}
