using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Paragraph : IDocumentComponent
    {
        private string _text;

        public Paragraph(string text)
        {
            _text = text;
        }

        public void Add(IDocumentComponent component)
        {
            throw new InvalidOperationException("Нельзя добавлять потомков к параграфу");
        }

        public void Remove(IDocumentComponent component)
        {
            throw new InvalidOperationException("У параграфа нет потомков");
        }

        public void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + _text);
        }
    }
}