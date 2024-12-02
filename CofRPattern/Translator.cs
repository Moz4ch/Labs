using CofRPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofRPattern
{
    public abstract class Translator
    {
        protected Translator _nextTranslator;
        public void SetNext(Translator translator)
        {
            _nextTranslator = translator;
        }
        public abstract void Translate(Request request);
    }
}