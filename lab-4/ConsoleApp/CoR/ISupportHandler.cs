using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    public interface ISupportHandler
    {
        void SetNextHandler(ISupportHandler next);
        bool HandleRequest(string issue);
    }
}
