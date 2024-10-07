public class Fruit : Product
{
    public string Color { get; set; }

    public override decimal Price => base.Price * 0.8m;

    public override string GetInformation()
    {
        return $"Товар: {Name}, Цвет: {Color}, Цена со скидкой: {Price:C}";
    }
}