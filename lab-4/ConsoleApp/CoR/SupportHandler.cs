using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    public abstract class SupportHandler : ISupportHandler
    {
        protected ISupportHandler nextHandler;

        public void SetNextHandler(ISupportHandler next)
        {
            nextHandler = next;
        }

        public abstract bool HandleRequest(string issue);
    }

}
