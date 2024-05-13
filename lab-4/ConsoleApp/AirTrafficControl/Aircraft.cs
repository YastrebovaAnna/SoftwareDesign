using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficControl
{
    public class Aircraft
    {
        public string Name { get; set; }
        public bool IsTakingOff { get; set; }

        public Aircraft(string name)
        {
            this.Name = name;
        }

        public void Land(CommandCentre commandCentre)
        {
            Console.WriteLine($"Aircraft {this.Name} is requesting to land.");
            commandCentre.RequestLanding(this.Name);
        }

        public void TakeOff(CommandCentre commandCentre)
        {
            Console.WriteLine($"Aircraft {this.Name} is requesting to take off.");
            commandCentre.RequestTakeOff(this.Name);
        }
    }
}
