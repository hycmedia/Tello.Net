using System;
using System.Collections.Generic;
using System.Linq;

namespace Tello.Net.Entities.ControlCommand
{
    public abstract class Command
    {
        public abstract string Name { get; set; }

        public Command(params int[] parameters)
        {
            this.AddParameters(parameters);
        }


        public Command(params string[] parameters)
        {
            this.AddParameters(parameters);
        }

        public Command()
        {
        }

        protected Command AddParameter(string parameter)
        {
            this.Name += $" {parameter}";

            return this;
        }

        protected Command AddParameter(int parameter)
        {
            this.AddParameter(parameter.ToString());

            return this;
        }

        protected void AddParameters(params string[] parameters)
        {
            parameters.ToList().ForEach(parameter =>
            {
                this.AddParameter(parameter);
            });
        }

        protected void AddParameters(params int[] parameters)
        {
            parameters.ToList().ForEach(parameter =>
            {
                this.AddParameter(parameter);
            });
        }
    }
}
