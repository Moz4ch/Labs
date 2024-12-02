using CofRPattern;

class Program
{
    static void Main()
    {
        var englishToGerman = new EnglishToGermanTranslator();
        var englishToChinese = new EnglishToChineseTranslator();
        var englishToRussian = new EnglishToRussianTranslator();

        englishToGerman.SetNext(englishToChinese);
        englishToChinese.SetNext(englishToRussian);

        var request1 = new Request("Chinese", "English", "Текст на китайском");
        englishToGerman.Translate(request1);
        var request2 = new Request("English", "Chinese", "Текст на английском");
        englishToGerman.Translate(request2);

        var request3 = new Request("Japanese", "English", "Текст на японском");
        englishToGerman.Translate(request3);
    }
}