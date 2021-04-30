using System;
namespace Tello.Net.Entities.ControlCommand
{
    public class RcCommand : Command
    {
        public override string Name { get; set; } = "rc";

        public RcCommand(int x, int y, int z, int yaw)
        {
            this.Name += $" {x} {y} {z} {yaw}";
        }
    }
}
