public class Electronics : Product
{
    public int WarrantyPeriod { get; set; }

    public override decimal Price => base.Price;

    public override string GetInformation()
    {
        return $"Товар: {Name}, Гарантия: {WarrantyPeriod} месяцев, Цена: {Price:C}";
    }
}