using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FormatHelper
    {
        public static string FormatMoney(IMoney money)
        {
            return $"{money.WholePart}.{money.FractionalPart:00} {money.CurrencyCode}";
        }

        public static string FormatWarehouseProduct(WarehouseProduct product)
        {
            return $"Product: {product.Product.Name}, Quantity: {product.Quantity}, Unit of Measure: {product.UnitOfMeasure}, Price: {FormatMoney(product.Price)}, Last Delivery Date: {product.LastDeliveryDate.ToShortDateString()}";
        }

        public static void DisplayInventory(List<WarehouseProduct> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(FormatWarehouseProduct(product));
            }
        }
    }
}
