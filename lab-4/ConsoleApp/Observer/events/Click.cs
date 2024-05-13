using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.events
{
    public class Click : IEventObserver
    {
        public void OnEvent()
        {
            Console.WriteLine("Click");
        }
    }
}
