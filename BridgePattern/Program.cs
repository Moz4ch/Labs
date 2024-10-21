using BridgePattern;

class Program
{
    static void Main()
    {
        INotification email = new EmailNotification();
        INotification sms = new SmsNotification();

        Notify emailNotification1 = new TextNotify(email);
        emailNotification1.SendNotify("Сегодня последний день сдачи студенческих!", "shimanovsky@mer.ci.nsu.ru");

        Notify emailNotification2 = new HTMLNotify(email);
        emailNotification2.SendNotify("Выставлены отметки за контрольную неделю", "koroteevsv@mer.ci.nsu.ru");

        Notify smsNotification1 = new TextNotify(sms);
        smsNotification1.SendNotify("Не забыл, что на сегодня забронирован столик?", "+7 (900) 383 31 56 ");

        Notify smsNotification2 = new HTMLNotify(sms);
        smsNotification2.SendNotify("Сегодня прекрасная погода!", "+7 (800) 555 35 35");
    }
}