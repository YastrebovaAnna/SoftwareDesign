using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextDocument
    {
        public string Content { get; set; }

        public TextDocument(string content)
        {
            Content = content;
        }

        public IMemento Save()
        {
            return new TextDocumentMemento(Content);
        }

        public void Restore(IMemento memento)
        {
            if (memento is TextDocumentMemento textMemento)
            {
                Content = textMemento.GetState();
            }
        }
    }
}
