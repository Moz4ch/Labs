using IteratorPattern;
using System.Collections;

class Program
{
    static void Main()
    {
        Library library = new Library();
        IEnumerator librarian = library.GetEnumerator();

        library.AddBook(new Book("Трансерфинг реальности", "Вадим Зеланд", 2007));
        library.AddBook(new Book("Анна Каренина", "Лев Толстой", 1878));
        library.AddBook(new Book("Граф Монте-Кристо", "Александр Дюма", 1844));
        
        while (librarian.MoveNext())
            Console.WriteLine(((Book)librarian.Current).Title);
    }
}