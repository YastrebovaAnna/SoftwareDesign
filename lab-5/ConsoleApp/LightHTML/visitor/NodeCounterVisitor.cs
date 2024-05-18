using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTML.visitor
{
    public class NodeCounterVisitor : ILightNodeVisitor
    {
        public int ElementNodeCount { get; private set; }
        public int TextNodeCount { get; private set; }

        public void Visit(LightElementNode elementNode)
        {
            ElementNodeCount++;
            foreach (var child in elementNode.Children)
            {
                child.Accept(this);
            }
        }

        public void Visit(LightTextNode textNode)
        {
            TextNodeCount++;
        }
    }
}
