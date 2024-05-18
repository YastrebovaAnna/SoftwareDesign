using Iterator;
using LightHTML.enums;
using LightHTML.state;
using LightHTML.template;
using LightHTML.visitor;
using System;
using System.Collections.Generic;

namespace LightHTML
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public DisplayType Display { get; set; }
        public ClosingType Closing { get; set; }
        public List<string> CssClasses { get; set; } = new List<string>();
        public List<LightNode> Children { get; set; } = new List<LightNode>();

        private IState _state;

        public LightElementNode(string tagName, DisplayType display, ClosingType closing)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
            _state = new InactiveState();
            CreateMethod();
        }

        public void SetState(IState state)
        {
            _state = state;
            _state.Handle(this);
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public void RemoveChild(LightNode child)
        {
            if (Children.Remove(child))
            {
                child.OnRemoved();
            }
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
                if (child is LightTextNode)
                    TextMethod();
            }
        }

        public override void OnCreate()
        {
            Console.WriteLine($"{TagName} was created");
        }

        public override void OnInserted()
        {
            Console.WriteLine($"{TagName} was inserted");
        }

        public override void OnTextRendered()
        {
            Console.Write("Text was rendered");
        }

        public override void OnRemoved()
        {
            Console.Write($"{TagName} was removed");
        }

        public override IIterator GetDepthFirstIterator()
        {
            return new DfsIterator(this);
        }

        public override IIterator GetBreadthFirstIterator()
        {
            return new BfsIterator(this);
        }
        
        public override void Accept(ILightNodeVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var child in Children)
            {
                child.Accept(visitor);
            }
        }
    }
}
