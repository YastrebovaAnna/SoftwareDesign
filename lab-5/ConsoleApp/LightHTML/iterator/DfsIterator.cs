using LightHTML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class DfsIterator : IIterator
    {
        private Stack<LightNode> stack = new Stack<LightNode>();

        public DfsIterator(LightNode root)
        {
            if (root != null)
            {
                stack.Push(root);
            }
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }

        public LightNode Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException();
            }

            var currentNode = stack.Pop();
            if (currentNode is LightElementNode elementNode)
            {
                foreach (var child in Enumerable.Reverse(elementNode.Children))
                {
                    stack.Push(child);
                }
            }

            return currentNode;
        }
    }

}
