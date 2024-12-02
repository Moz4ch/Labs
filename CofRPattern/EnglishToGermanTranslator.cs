using CofRPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofRPattern
{
    public class EnglishToGermanTranslator : Translator
    {
        public override void Translate(Request request)
        {
            if (request.SourceLanguage == "English" && request.TargetLanguage == "German")
            {
                Console.WriteLine($"Перевод с английского на немецкий: {request.Document}");
            }
            else if (request.SourceLanguage == "German" && request.TargetLanguage == "English")
            {
                Console.WriteLine($"Перевод с немецкого на английский: {request.Document}");
            }
            else if (_nextTranslator != null)
            {
                _nextTranslator.Translate(request);
            }
            else
            {
                Console.WriteLine("Невозможно перевести документ");
            }
        }
    }
}