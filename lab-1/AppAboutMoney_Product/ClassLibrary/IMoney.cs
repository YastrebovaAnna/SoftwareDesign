using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IMoney
    {
        int WholePart { get; }
        int FractionalPart { get; }
        string CurrencyCode { get; }
        void ChangeValue(int whole, int fractional);
    }
}
