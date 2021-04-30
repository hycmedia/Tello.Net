using System;
using System.Collections.Generic;

namespace Tello.Net.Entities.ControlCommand
{
    public class TakeoffCommand : Command
    {
        public override string Name { get; set; } = "takeoff";
    }
}
