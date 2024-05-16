﻿using Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTML
{
    public class LightTextNode : LightNode
    {
        protected string Text { get; set; }

        public LightTextNode(string text)
        {
            Text = text;
        }

        public override void OuterHTML()
        {
            Console.Write(Text);
        }
        public override IIterator GetDepthFirstIterator()
        {
            return new DfsIterator(this);
        }

        public override IIterator GetBreadthFirstIterator()
        {
            return new BfsIterator(this);
        }
    }

}
