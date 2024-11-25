using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Decorator : Component
    {
        protected Component _wrapped;

        public Decorator(Component wrapped)
        {
            _wrapped = wrapped;
        }
        public override void Send(string message, List<string> recipients)
        {
            _wrapped.Send(message, recipients);
        }
    }
}