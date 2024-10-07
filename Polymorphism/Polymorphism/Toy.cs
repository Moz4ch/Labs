public class Toy : Product
{
    public string Material { get; set; }

    public override decimal Price => base.Price * 0.9m;

    public override string GetInformation()
    {
        return $"Товар: {Name}, Материал: {Material}, Цена со скидкой: {Price:C}";
    }
}