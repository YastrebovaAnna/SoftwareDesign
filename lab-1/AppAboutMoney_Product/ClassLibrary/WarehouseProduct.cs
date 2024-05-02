using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WarehouseProduct
    {
        public Product Product { get; private set; }
        public string UnitOfMeasure { get; private set; }
        public int Quantity { get; set; }
        public IMoney Price => Product.Price;
        public DateTime LastDeliveryDate { get; private set; }
        public WarehouseProduct(Product product, string unitOfMeasure, int quantity, DateTime lastDeliveryDate)
        {
            Product = product ?? throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            UnitOfMeasure = unitOfMeasure;
            Quantity = quantity;
            LastDeliveryDate = lastDeliveryDate;
        }
    }
}
