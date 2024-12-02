using CofRPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofRPattern
{
    public class EnglishToRussianTranslator : Translator
    {
        public override void Translate(Request request)
        {
            if (request.SourceLanguage == "English" && request.TargetLanguage == "Russian")
            {
                Console.WriteLine($"Перевод с английского на русский: {request.Document}");
            }
            else if (request.SourceLanguage == "Russian" && request.TargetLanguage == "English")
            {
                Console.WriteLine($"Перевод с русского на английский: {request.Document}");
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