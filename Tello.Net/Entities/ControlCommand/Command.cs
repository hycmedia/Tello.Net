using System;
using System.Collections.Generic;

namespace Tello.Net.Entities.ControlCommand
{
    public abstract class Command
    {
        public abstract string Name { get; set; }

        public void AddParameter(string parameter)
        {
            this.Name += $" {parameter}";
        }

        public void AddParameter(int parameter)
        {
            this.AddParameter(parameter.ToString());
        } 
    }
}
