using Production_OfEquipment.Interfaces;
using Production_OfEquipment.Products.IProne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production_OfEquipment.Factories
{
    public class IProneFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new IProneLaptop();
        public INetbook CreateNetbook() => new IProneNetbook();
        public IEBook CreateEBook() => new IProneEBook();
        public ISmartphone CreateSmartphone() => new IProneSmartphone();
    }
}
