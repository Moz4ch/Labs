using CofRPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofRPattern
{
    public class EnglishToChineseTranslator : Translator
    {
        public override void Translate(Request request)
        {
            if (request.SourceLanguage == "English" && request.TargetLanguage == "Chinese")
            {
                Console.WriteLine($"Перевод с английского на китайский: {request.Document}");
            }
            else if (request.SourceLanguage == "Chinese" && request.TargetLanguage == "English")
            {
                Console.WriteLine($"Перевод с китайского на английский: {request.Document}");
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