using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR.levels
{
    public class IntermediateSupportHandler : SupportHandler
    {
        public override bool HandleRequest(string issue)
        {
            if (issue == "intermediate")
            {
                Console.WriteLine("Intermediate Support: Допомога по питанню рівня Intermediate.");
                return true;
            }
            else
            {
                Console.WriteLine("Intermediate Support can't solve the problem, redirecting to the next level...");
                return nextHandler?.HandleRequest(issue) ?? false;
            }
        }
    }
}
