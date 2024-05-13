using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTrafficControl
{
    public class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);
        }

        public bool RequestLanding(string aircraftName)
        {
            var aircraft = _aircrafts.Find(a => a.Name == aircraftName);
            if (aircraft == null)
            {
                Console.WriteLine($"Aircraft {aircraftName} not found.");
                return false;
            }

            foreach (var runway in _runways)
            {
                if (!runway.IsBusy)
                {
                    runway.IsBusy = true;
                    runway.HighLightRed();
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed on runway {runway.Id}.");
                    return true;
                }
            }
            Console.WriteLine($"No available runway for aircraft {aircraft.Name} to land.");
            return false;
        }

        public void RequestTakeOff(string aircraftName)
        {
           var aircraft = _aircrafts.Find(a => a.Name == aircraftName);
           if (aircraft == null)
            {
                Console.WriteLine($"Aircraft {aircraftName} not found.");
                return;
            }

            foreach (var runway in _runways)
            {
                if (runway.IsBusy)
                {
                    runway.IsBusy = false;
                    runway.HighLightGreen();
                    Console.WriteLine($"Aircraft {aircraft.Name} has taken off from runway {runway.Id}.");
                    return;
                }
            }
            Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
        }
    }
}
