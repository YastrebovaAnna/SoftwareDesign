using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR.levels
{
    public class ExpertSupportHandler : SupportHandler
    {
        public override bool HandleRequest(string issue)
        {
            if (issue == "expert")
            {
                Console.WriteLine("Expert Support.");
                return true;
            }
            else
            {
                Console.WriteLine("Expert Support unable to resolve the issue. Contact an administrator..");
                return false;
            }
        }
    }
}
