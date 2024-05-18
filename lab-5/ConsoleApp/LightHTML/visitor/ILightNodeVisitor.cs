using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTML.visitor
{
    public interface ILightNodeVisitor
    {
        void Visit(LightElementNode elementNode);
        void Visit(LightTextNode textNode);
    }
}
