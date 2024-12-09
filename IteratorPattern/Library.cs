using IteratorPattern;
using System.Collections;

internal class Library : IEnumerable<Book>
{
    private Book[] books = new Book[0];
    private int index;
    public Book this[int index]
    {
        get { return books[index]; }
        set { books[index] = value; }
    }

    public int Count
    {
        get { return index; }
    }
    public void AddBook(Book book)
    {
        if (index == books.Length) Array.Resize(ref books, books.Length + 1);
        books[index] = book;
        index++;
    }
    public IEnumerator<Book> GetEnumerator()
    {
        return new Employee(this);
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}