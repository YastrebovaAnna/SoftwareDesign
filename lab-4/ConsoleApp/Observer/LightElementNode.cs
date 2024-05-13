using LightHTML.enums;
using Observer;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTML
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public DisplayType Display { get; set; }
        public ClosingType Closing { get; set; }
        public List<string> CssClasses { get; set; } = new List<string>();
        public List<LightNode> Children { get; set; } = new List<LightNode>();
    
        private List<IEventObserver> subscribers = new List<IEventObserver>();

        public LightElementNode(string tagName, DisplayType display, ClosingType closing)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
        }
        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public void AddCssClass(string cssClass)
        {
            CssClasses.Add(cssClass);
        }
        public override void OuterHTML()
        {
            Console.Write($"<{TagName}");

            if (CssClasses.Count > 0)
                Console.Write($" class=\"{string.Join(" ", CssClasses)}\"");

            Console.Write(">");

            if (Closing == ClosingType.Paired)
            {
                InnerHTML();
                Console.Write($"</{TagName}>");
            }
            else
                Console.Write("/>");
        }

        public void InnerHTML()
        {
            foreach (var child in Children)
            {
                child.OuterHTML();
            }
        }
        public void AddEventListener(IEventObserver subscriber)
        {
            this.subscribers.Add(subscriber);
        }
        public void RemoveEventListener(IEventObserver subscriber)
        {
            this.subscribers.Remove(subscriber);
        }
        public void NotifyEventListeners()
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.OnEvent();
            }
        }
    }
}
