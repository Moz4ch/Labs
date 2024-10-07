public class Meat : Product
{
    public double Weight { get; set; }

    public override decimal Price => base.Price * 0.85m;

    public override string GetInformation()
    {
        return $"Товар: {Name}, Вес: {Weight} кг, Цена со скидкой: {Price:C}";
    }
}