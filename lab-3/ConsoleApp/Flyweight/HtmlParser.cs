using LightHTML.enums;
using LightHTML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class HtmlParser
    {
        private LightElementFactory factory;

        public HtmlParser(LightElementFactory factory)
        {
            this.factory = factory;
        }

        public LightElementNode ParseBook(string[] lines)
        {
            LightElementNode root = factory.GetElement("div", DisplayType.Block, ClosingType.Paired);

            bool isFirstLine = true;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;
                LightNode node;

                if (isFirstLine)
                {
                    node = new LightTextNode($"<h1>{line}</h1>");
                    isFirstLine = false;
                }
                else if (line.Length < 20)
                {
                    node = new LightTextNode($"<h2>{line}</h2>");
                }
                else if (line.StartsWith(" "))
                {
                    node = new LightTextNode($"<blockquote>{line}</blockquote>");
                }
                else
                {
                    node = new LightTextNode($"<p>{line}</p>");
                }

                root.AddChild(node);
            }

            return root;
        }
    }
}
