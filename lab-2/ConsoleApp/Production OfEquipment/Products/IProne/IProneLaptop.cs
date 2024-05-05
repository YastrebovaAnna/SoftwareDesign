using Production_OfEquipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production_OfEquipment.Products.IProne
{
    public class IProneLaptop : ILaptop
    {
        public void ShowInfo() => Console.WriteLine("IProne Laptop");
    }
}
