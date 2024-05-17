using LightHTML.template;
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
    }
}
