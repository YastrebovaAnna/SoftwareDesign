using LightHTML.visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTML
{
    public abstract class LightNode
    {
        public abstract void OuterHTML();
        public abstract void Accept(ILightNodeVisitor visitor);
    }
}
