using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public interface INotification
    {
        void SendNotification(string message, string recipient);
    }
    public class EmailNotification : INotification
    {
        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($"Отправка email для {recipient}: {message}");
        }
    }
    public class SmsNotification : INotification
    {
        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($"Отправка СМС для {recipient}: {message}");
        }
    }
}