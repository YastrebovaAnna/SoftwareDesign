using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditor : ICareTaker
    {
        private TextDocument _document;
        private Stack<IMemento> _history = new Stack<IMemento>();

        public TextEditor(TextDocument document)
        {
            _document = document;
        }

        public void ChangeContent(string newContent)
        {
            Save();
            _document.Content = newContent;
        }

        public void Save()
        {
            _history.Push(_document.Save());
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                _document.Restore(_history.Pop());
            }
        }

        public string GetContent()
        {
            return _document.Content;
        }
    }
}
