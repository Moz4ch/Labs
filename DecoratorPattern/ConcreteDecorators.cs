using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class SMSDecorator : Decorator
    {
        public SMSDecorator(Component wrapped) : base(wrapped) { }

        public override void Send(string message, List<string> recipients)
        {
            base.Send(message, recipients);

            foreach (var recipient in recipients)
            {
                if (recipient.StartsWith("+"))
                {
                    Console.WriteLine($"Отправка СМС на номер {recipient}: {message}");
                }
            }
        }
    }
    public class TelegramDecorator : Decorator
    {
        public TelegramDecorator(Component wrapped) : base(wrapped) { }

        public override void Send(string message, List<string> recipients)
        {
            foreach (var recipient in recipients)
            {
                if (recipient.StartsWith("@"))
                {
                    Console.WriteLine($"Отправка сообщения в телеграмм для {recipient}: {message}");
                }
            }
        }
    }
}