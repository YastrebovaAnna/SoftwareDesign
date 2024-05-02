namespace ClassLibrary
{
    using System;

    public class Reporting
    {
        private Warehouse warehouse;

        public Reporting(Warehouse warehouse)
        {
            this.warehouse = warehouse ?? throw new ArgumentNullException(nameof(warehouse), "Warehouse cannot be null.");
        }

        public void GenerateInventoryReport()
        {
            warehouse.DisplayInventory();
        }

        public void RegisterProductReception(WarehouseProduct product)
        {
            warehouse.AddProduct(product);
        }

        public void RegisterProductShipment(WarehouseProduct product)
        {
            warehouse.RemoveProduct(product);
        }
    }
}
