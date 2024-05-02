using ClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        UAH uah = new UAH(60, 20);
        Product product = new Product("Apple", uah); 
        Warehouse warehouse = new Warehouse();

        WarehouseProduct warehouseProduct = new WarehouseProduct(product, "kg", 150, DateTime.Now.AddDays(-10));

        warehouse.AddProduct(warehouseProduct);

        Reporting reporting = new Reporting(warehouse);

        Console.WriteLine("Initial Inventory:");
        reporting.GenerateInventoryReport();

        product.ReducePrice(0, 50); 
        Console.WriteLine("\nInventory after price changes:");
        reporting.GenerateInventoryReport();

       
        reporting.RegisterProductShipment(warehouseProduct);  

        Console.WriteLine("\nInventory after shipping some aplles:");

        reporting.RegisterProductReception(new WarehouseProduct(new Product("Orange", new UAH(1, 75)), "kg", 100, DateTime.Now));

        Console.WriteLine("\nFinal Inventory after receiving oranges:");
        reporting.GenerateInventoryReport();
    }
}