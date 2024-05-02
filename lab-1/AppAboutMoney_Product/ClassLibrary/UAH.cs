using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class UAH : Money, IMoney
    {
        public UAH(int wholePart, int fractionalPart) : base(wholePart, fractionalPart)
        {
            CurrencyCode = "UAH";
        }
    }
}
