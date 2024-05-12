using LightHTML.enums;
using LightHTML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class LightElementFactory
    {
        private Dictionary<string, LightElementNode> elementCache = new Dictionary<string, LightElementNode>();

        public LightElementNode GetElement(string tagName, DisplayType display, ClosingType closing)
        {
            string key = $"{tagName}_{display}_{closing}";
            if (!elementCache.ContainsKey(key))
            {
                elementCache[key] = new LightElementNode(tagName, display, closing);
            }

            return elementCache[key];
        }
    }
}
