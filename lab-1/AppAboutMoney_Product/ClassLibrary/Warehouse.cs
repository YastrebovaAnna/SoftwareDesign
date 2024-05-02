namespace ClassLibrary
{
    using System;
    using System.Collections.Generic;

    public class Warehouse
    {
        private List<WarehouseProduct> inventory;
        public Warehouse()
        {
            inventory = new List<WarehouseProduct>();
        }

        private void CheckProductNotNull(WarehouseProduct product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product), "Product cannot be null.");
        }

        public void AddProduct(WarehouseProduct product)
        {
            CheckProductNotNull(product);
            inventory.Add(product);
        }

        public void RemoveProduct(WarehouseProduct product)
        {
            CheckProductNotNull(product);
            inventory.Remove(product);
        }
        public void DisplayInventory()
        {
            FormatHelper.DisplayInventory(inventory);
        }
    }
}
