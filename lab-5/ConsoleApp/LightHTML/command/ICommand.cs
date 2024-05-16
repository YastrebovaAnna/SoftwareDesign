using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTML.command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
