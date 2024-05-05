using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production_OfEquipment.Interfaces
{
    public interface IDeviceFactory
    {
        ILaptop CreateLaptop();
        INetbook CreateNetbook();
        IEBook CreateEBook();
        ISmartphone CreateSmartphone();
    }
}
