using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ConcreteComponent : Component
    {
        public override void Send(string message, List<string> recipients)
        {
            foreach (var recipient in recipients)
            {
                if (recipient.Contains("@") && !recipient.StartsWith("@"))
                {
                    Console.WriteLine($"Отправка Email для {recipient}: {message}");
                }
            }
        }
    }
}