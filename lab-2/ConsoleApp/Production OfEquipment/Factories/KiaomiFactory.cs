using Production_OfEquipment.Interfaces;
using Production_OfEquipment.Products.Kiaomi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production_OfEquipment.Factories
{
    public class KiaomiFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new KiaomiLaptop();
        public INetbook CreateNetbook() => new KiaomiNetbook();
        public IEBook CreateEBook() => new KiaomiEBook();
        public ISmartphone CreateSmartphone() => new KiaomiSmartphone();
    }
}
