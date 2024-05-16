using LightHTML.enums;
using LightHTML;
using Iterator;

class Program
{
    static void Main(string[] args)
    {
        // Task 1

        LightElementNode html = new LightElementNode("html", DisplayType.Block, ClosingType.Paired);
        LightElementNode body = new LightElementNode("body", DisplayType.Block, ClosingType.Paired);
        LightElementNode divMain = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);
        divMain.AddCssClass("main");
        LightElementNode h1 = new LightElementNode("h1", DisplayType.Block, ClosingType.Paired);
        LightTextNode h1Text = new LightTextNode("Welcome");
        LightElementNode divContent = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);
        divContent.AddCssClass("content");
        LightElementNode p = new LightElementNode("p", DisplayType.Block, ClosingType.Paired);
        LightTextNode pText = new LightTextNode("Description here.");
        LightElementNode divNested = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);
        LightElementNode span = new LightElementNode("span", DisplayType.Inline, ClosingType.Paired);
        LightTextNode spanText = new LightTextNode("More details");

        h1.AddChild(h1Text);
        span.AddChild(spanText);
        p.AddChild(pText);
        divNested.AddChild(span);
        divContent.AddChild(p);
        divContent.AddChild(divNested);
        divMain.AddChild(h1);
        divMain.AddChild(divContent);
        body.AddChild(divMain);
        html.AddChild(body);

        IIterator depthFirstIterator = html.GetDepthFirstIterator();
        Console.WriteLine("Depth First Traversal:");
        while (depthFirstIterator.HasNext())
        {
            LightNode node = depthFirstIterator.Next();
            node.OuterHTML();
            Console.WriteLine();
        }

        IIterator breadthFirstIterator = html.GetBreadthFirstIterator();
        Console.WriteLine("Breadth First Traversal:");
        while (breadthFirstIterator.HasNext())
        {
            LightNode node = breadthFirstIterator.Next();
            node.OuterHTML();
            Console.WriteLine();
        }
    }
}