using LightHTML;
using LightHTML.enums;
using System;
class Program
{
    static void Main(string[] args)
    {
        LightElementNode div = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);
        LightTextNode textNode = new LightTextNode("Hello, World!");

        div.AddChild(textNode);
        div.OuterHTML();

        div.RemoveChild(textNode);
    }
}
