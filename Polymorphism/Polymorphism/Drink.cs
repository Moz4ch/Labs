public class Drink : Product
{
    public int Volume { get; set; }

    public override decimal Price => base.Price * 0.95m;

    public override string GetInformation()
    {
        return $"Товар: {Name}, Объем: {Volume} мл, Цена со скидкой: {Price:C}";
    }
}