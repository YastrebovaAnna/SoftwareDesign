using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR.levels
{
    public class BasicSupportHandler : SupportHandler
    {
        public override bool HandleRequest(string issue)
        {
            if (issue == "basic")
            {
                Console.WriteLine("Basic Support");
                return true;
            }
            else
            {
                Console.WriteLine("Basic Support can't solve the problem, redirecting to the next level...");
                return nextHandler?.HandleRequest(issue) ?? false;
            }
        }
    }
}
