using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTML.command
{
    public class RemoveCssClassCommand : ICommand
    {
        private readonly LightElementNode _elementNode;
        private readonly string _cssClass;

        public RemoveCssClassCommand(LightElementNode elementNode, string cssClass)
        {
            _elementNode = elementNode;
            _cssClass = cssClass;
        }

        public void Execute()
        {
            _elementNode.CssClasses.Remove(_cssClass);
        }

        public void Undo()
        {
            _elementNode.AddCssClass(_cssClass);
        }
    }
}
