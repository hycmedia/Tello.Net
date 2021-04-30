using System;
using System.Collections.Generic;

namespace Tello.Net.Entities.ControlCommand
{
    public abstract class Command
    {
        public abstract string Name { get; set; }

        public Command AddParameter(string parameter)
        {
            this.Name += $" {parameter}";

            return this;
        }

        public Command AddParameter(int parameter)
        {
            this.AddParameter(parameter.ToString());

            return this;
        }
    }
}
