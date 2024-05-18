using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTML.template
{
    public abstract class Hooks
    {
        public void CreateMethod()
        {
            OnCreate();
            OnInserted();
        }
        public void TextMethod()
        {
            OnTextRendered();
        }
        public void RemoveMethod()
        {
            OnRemoved();
        }
        public virtual void OnCreate() { }
        public virtual void OnInserted() { }
        public virtual void OnTextRendered() { }
        public virtual void OnRemoved() { }
    }
}
