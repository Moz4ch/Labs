using IteratorPattern;
using System.Collections;

internal class Employee : IEnumerator<Book>
{
    private Library library;
    private int current = -1;
    public Employee(Library enumerable)
    {
        this.library = enumerable;
    }
    public bool MoveNext()
    {
        if (current < library.Count - 1)
        {
            current++;
            return true;
        }
        return false;
    }
    public void Reset()
    {
        current = -1;
    }
    public Book Current
    {
        get { return library[current]; }
    }
    object IEnumerator.Current => Current;
    public void Dispose()
    {
    }
}