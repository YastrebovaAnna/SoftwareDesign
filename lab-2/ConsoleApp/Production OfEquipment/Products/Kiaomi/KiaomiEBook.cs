﻿using Production_OfEquipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production_OfEquipment.Products.Kiaomi
{
    public class KiaomiEBook : IEBook
    {
        public void ShowInfo() => Console.WriteLine("Kiaomi EBook");
    }
}
