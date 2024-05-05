using Production_OfEquipment.Interfaces;
using Production_OfEquipment.Products.Balaxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production_OfEquipment.Factories
{
    public class BalaxyFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new BalaxyLaptop();
        public INetbook CreateNetbook() => new BalaxyNetbook();
        public IEBook CreateEBook() => new BalaxyEBook();
        public ISmartphone CreateSmartphone() => new BalaxySmartphone();
    }
}
