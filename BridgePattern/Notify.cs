using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Notify
    {
        protected INotification _notification;
        protected Notify(INotification notificationService)
        {
            _notification = notificationService;
        }
        public abstract void SendNotify(string message, string recipient);
    }
    public class HTMLNotify : Notify
    {
        public HTMLNotify(INotification notificationService)
            : base(notificationService) { }
        public override void SendNotify(string message, string recipient)
        {
            string htmlMessage = $"<h4>{message}</h4>";
            _notification.SendNotification(htmlMessage, recipient);
        }
    }
    public class TextNotify : Notify
    {
        public TextNotify(INotification notificationService)
            : base(notificationService) { }
        public override void SendNotify(string message, string recipient)
        {
            _notification.SendNotification(message, recipient);
        }
    }

}
