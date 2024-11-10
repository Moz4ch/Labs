using CompositePattern;
using System.ComponentModel;

public class Program
{
    public static void Main(string[] args)
    {
        Document document = new Document("Обзор современных автомобилей");

        Section sectionMain = new Section("Типы автомобилей");
        sectionMain.Add(new Paragraph("Параграф 1.1: Легковые автомобили \r\nПараграф 1.1.1: Седаны\r\nПараграф 1.2.2: Хэтчбеки\r\nПараграф 1.3.2: Купе и кабриолеты"));
        sectionMain.Add(new Paragraph("Параграф 1.2: Внедорожники и кроссоверы\r\nПараграф 1.2.1: Компактные кроссоверы\r\nПараграф 1.2.2: Среднеразмерные внедорожники\r\nПараграф 1.2.3: Полноразмерные внедорожники"));
        sectionMain.Add(new Paragraph("Параграф 1.3: Грузовые автомобили\r\nПараграф 1.3.1: Пикапы\r\nПараграф 1.3.2: Фургоны и грузовики"));

        Section sectionTA = new Section("Технологии в автомобилях");
        sectionTA.Add(new Paragraph("Параграф 2.1: Двигатели и топливные системы\r\nПараграф 2.1.1: Бензиновые и дизельные двигатели\r\nПараграф 2.1.2: Гибридные автомобили\r\nПараграф 2.1.3: Электрические автомобили"));
        sectionTA.Add(new Paragraph("Параграф 2.2: Трансмиссии\r\nПараграф 2.2.1: Механическая трансмиссия\r\nПараграф 2.2.2: Автоматическая трансмиссия\r\nПараграф 2.2.3: Роботизированная коробка передач"));
        sectionTA.Add(new Paragraph("Параграф 2.3: Системы безопасности\r\nПараграф 2.3.1: Антиблокировочная система тормозов (ABS)\r\nПараграф 2.3.2: Подушки безопасности\r\nПараграф 2.3.3: Системы помощи водителю (ADAS)"));

        Section sectionPRA = new Section("Перспективы развития автомобилестроения");
        sectionPRA.Add(new Paragraph("Параграф 3.1: Автомобили с автопилотом"));
        sectionPRA.Add(new Paragraph("Параграф 3.2: Экологические технологии\r\nПараграф 3.2.1: Снижение выбросов CO₂\r\nПараграф 3.2.2: Использование альтернативных источников энергии"));
        sectionPRA.Add(new Paragraph("Параграф 3.3: Автономные транспортные средства и каршеринговые услуги"));

        Section sectionPBA = new Section("Популярные бренды автомобилей");
        sectionPBA.Add(new Paragraph("Параграф 4.1: Европейские производители\r\nПараграф 4.1.1: Volkswagen\r\nПараграф 4.1.2: BMW\r\nПараграф 4.1.3: Mercedes-Benz"));
        sectionPBA.Add(new Paragraph("Параграф 4.2: Американские производители\r\nПараграф 4.2.1: Ford\r\nПараграф 4.2.2: Tesla\r\nПараграф 4.2.3: General Motors"));
        sectionPBA.Add(new Paragraph("Параграф 4.3: Азиатские производители\r\nПараграф 4.3.1: Toyota\r\nПараграф 4.3.2: Honda\r\nПараграф 4.3.3: Hyundai"));



        document.Add(sectionMain);
        document.Add(sectionTA);
        document.Add(sectionPRA);
        document.Add(sectionPBA);
        document.Display();

        Console.WriteLine("При покупке авто часто смотрят");
        sectionPRA.Remove(sectionPRA);
        document.Display();

    }
}