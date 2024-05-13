using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextDocumentMemento : IMemento
    {
        private string _content;

        public TextDocumentMemento(string content)
        {
            _content = content;
        }

        public string GetState()
        {
            return _content;
        }
    }
}
