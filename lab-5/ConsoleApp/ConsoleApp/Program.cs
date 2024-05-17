using LightHTML;
using LightHTML.enums;
using LightHTML.visitor;

class Program
{
    static void Main(string[] args)
    {
        var root = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);
        root.AddCssClass("container");
        root.AddChild(new LightTextNode("Hello, World!"));

        var child = new LightElementNode("p", DisplayType.Block, ClosingType.Paired);
        child.AddChild(new LightTextNode("This is a paragraph."));
        root.AddChild(child);

        root.OuterHTML();

        var visitor = new NodeCounterVisitor();
        root.Accept(visitor);

        Console.WriteLine($"\nElement Nodes: {visitor.ElementNodeCount}");
        Console.WriteLine($"Text Nodes: {visitor.TextNodeCount}");
    }
}