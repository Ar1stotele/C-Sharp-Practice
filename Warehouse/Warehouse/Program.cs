using WarehouseNamespace;


class Program
{
    public static void Main(string[] args)
    {
        var warehouse = new Warehouse();

        warehouse.ListAllProducts();
        var protein = warehouse.RegisterProduct("Protein", Category.Sport, 50.55, 4);
        var pizza = warehouse.RegisterProduct("Pizza", Category.Food, 12.55, 10);
        var hugo = warehouse.RegisterProduct("The Man Who Laughs", Category.Book, 20.55, 1);
        var lenovo = warehouse.RegisterProduct("Lenovo: Gaming Laptop", Category.Tech, 3400.55, 2);
        warehouse.ListAllProducts();
        warehouse.ChangeProductPriceAndQuantity(lenovo, "Lenovo: IdeaPad", 5);
        warehouse.DeleteProduct(protein);
        warehouse.ListAllProducts();
        //var dell = warehouse.RegisterProduct("Lenovo: Gaming Laptop", Category.Tech, 3400.55, -2);

    }
}