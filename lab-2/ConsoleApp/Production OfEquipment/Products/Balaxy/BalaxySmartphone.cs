using Production_OfEquipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production_OfEquipment.Products.Balaxy
{
    public class BalaxySmartphone : ISmartphone
    {
        public void ShowInfo() => Console.WriteLine("Balaxy Smartphone");
    }
}
