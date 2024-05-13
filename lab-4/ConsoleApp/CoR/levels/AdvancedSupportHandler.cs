using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR.levels
{
    public class AdvancedSupportHandler : SupportHandler
    {
        public override bool HandleRequest(string issue)
        {
            if (issue == "advanced")
            {
                Console.WriteLine("Advanced Support.");
                return true;
            }
            else
            {
                Console.WriteLine("Advanced Support can't solve the problem, redirecting to the next level...");
                return nextHandler?.HandleRequest(issue) ?? false;
            }
        }
    }
}
