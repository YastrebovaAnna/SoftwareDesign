using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTML.command
{
  public class AddCssClassCommand : ICommand
  {
        private readonly LightElementNode _elementNode;
        private readonly string _cssClass;

        public AddCssClassCommand(LightElementNode elementNode, string cssClass)
        {
            _elementNode = elementNode;
            _cssClass = cssClass;
        }

        public void Execute()
        {
            _elementNode.AddCssClass(_cssClass);
        }

        public void Undo()
        {
            _elementNode.CssClasses.Remove(_cssClass);
        }
  }
}
