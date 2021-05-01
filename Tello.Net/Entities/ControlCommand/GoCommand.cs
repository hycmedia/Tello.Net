using System;
namespace Tello.Net.Entities.ControlCommand
{
    public class GoCommand : Command
    {
        public override string Name { get; set; } = "go";

        public GoCommand(int x, int y, int z, int speed, string mid) :
            base(x.ToString(), y.ToString(), z.ToString(), speed.ToString(), mid)
        {
        }
    }
}
