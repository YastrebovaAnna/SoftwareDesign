using ClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        UAH uah = new UAH(60, 20);
        Product product1 = new Product("Apple", uah); 
        Product product2 = new Product("Banana", uah); 
        Warehouse warehouse = new Warehouse();

        WarehouseProduct warehouseProduct1 = new WarehouseProduct(product1, "kg", 150, DateTime.Now.AddDays(-10));
        WarehouseProduct warehouseProduct2 = new WarehouseProduct(product2, "kg", 180, DateTime.Now.AddDays(-20));

        warehouse.AddProduct(warehouseProduct1);
        warehouse.AddProduct(warehouseProduct2);

        Reporting reporting = new Reporting(warehouse);

        Console.WriteLine("Initial Inventory:");
        reporting.GenerateInventoryReport();

        product1.ReducePrice(0, 50); 
        product2.ReducePrice(1, 0);
        Console.WriteLine("\nInventory after price changes:");
        reporting.GenerateInventoryReport();

       
        reporting.RegisterProductShipment(warehouseProduct2);  

        Console.WriteLine("\nInventory after shipping some bananas:");
        reporting.GenerateInventoryReport();

        reporting.RegisterProductReception(new WarehouseProduct(new Product("Orange", new UAH(1, 75)), "kg", 100, DateTime.Now));

        Console.WriteLine("\nFinal Inventory after receiving oranges:");
        reporting.GenerateInventoryReport();
    }
}