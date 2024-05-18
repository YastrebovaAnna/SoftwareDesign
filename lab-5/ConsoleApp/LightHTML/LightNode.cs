using LightHTML.template;
using Iterator;
using LightHTML.visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTML
{
    public abstract class LightNode : Hooks
    {
        public abstract void OuterHTML();
        public abstract void Accept(ILightNodeVisitor visitor);
        public abstract IIterator GetDepthFirstIterator();
        public abstract IIterator GetBreadthFirstIterator();
    }
}
