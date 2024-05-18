using LightHTML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class BfsIterator : IIterator
    {
        private Queue<LightNode> queue = new Queue<LightNode>();

        public BfsIterator(LightNode root)
        {
            if (root != null)
            {
                queue.Enqueue(root);
            }
        }

        public bool HasNext()
        {
            return queue.Count > 0;
        }

        public LightNode Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException();
            }

            var currentNode = queue.Dequeue();
            if (currentNode is LightElementNode elementNode)
            {
                foreach (var child in elementNode.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return currentNode;
        }
    }

}
