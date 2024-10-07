class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Toy { Name = "Плюшевая игрушка", Material = "Пух", Price = 100 },
            new Meat { Name = "Куриное филе", Weight = 1.5, Price = 200 },
            new Drink { Name = "Сок", Volume = 500, Price = 60 },
            new Fruit { Name = "Яблоко", Color = "Красное", Price = 50 },
            new Electronics { Name = "Телевизор", WarrantyPeriod = 24, Price = 3000 }
        };

        foreach (var product in products)
        {
            Console.WriteLine(product.GetInformation());
        }
    }
}