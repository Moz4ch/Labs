using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Document : Component
    {
        private List<IDocumentComponent> _sections = new List<IDocumentComponent>();
        private string _title;

        public Document(string title)
        {
            _title = title;
        }

        public void Add(IDocumentComponent component)
        {
            _sections.Add(component);
        }

        public void Remove(IDocumentComponent component)
        {
            _sections.Remove(component);
        }

        public void Display()
        {
            Console.WriteLine($"Документ: {_title}");
            foreach (var section in _sections)
            {
                section.Display(2);
            }
           Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
