using DecoratorPattern;

public class Program
{
    public static void Main(string[] args)
    {
        string message1 = "Я машину купил, погнали кататься!";
        var recipientContacts1 = new List<string>
        {
            "perekrestovds@mer.ci.nsu.ru",
            "+79139537754",
            "@Moz4ch"
        };
        Component component = new ConcreteComponent();
        Component telegramComponent = new TelegramDecorator(component);
        telegramComponent.Send(message1, recipientContacts1);
        Console.WriteLine();


        string message2 = "Сегодня ясная погода";
        var recipientContacts2 = new List<string>
        {
            "StepanenkoVP@mer.ci.nsu.ru",
            "+79536719051",
            "@Vladikkkk"
        };
        Component component1 = new ConcreteComponent();
        Component telegramComponent1 = new TelegramDecorator(component1);
        Component smsComponent1 = new SMSDecorator(telegramComponent1);
        smsComponent1.Send(message2, recipientContacts2);
        Console.WriteLine();

        string message3 = "Возьму ипотеку";
        var recipientContacts3 = new List<string>
        {
            "morojenoe@mail.ru",
            "+78005553535"
        };
        Component component2 = new ConcreteComponent();
        component2.Send(message3, recipientContacts3);
        Console.WriteLine();
    }
}