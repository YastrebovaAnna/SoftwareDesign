using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product
    {
        public string Name { get; set; }
        public IMoney Price { get; private set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void ReducePrice(int whole, int fractional)
        {
            Price.ChangeValue(-whole, -fractional);
        }
    }
}
