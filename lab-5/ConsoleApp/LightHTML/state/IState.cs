using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTML.state
{
    public interface IState
    {
        void Handle(LightElementNode node);
    }
}
