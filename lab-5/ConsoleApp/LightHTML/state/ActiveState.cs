using LightHTML.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTML.state
{
    public class ActiveState : IState
    {
        public void Handle(LightElementNode node)
        {
            node.Display = DisplayType.Visible;
            Console.WriteLine("Node is now active.");
        }
    }
}
