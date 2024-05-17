using LightHTML;
using LightHTML.enums;
using LightHTML.state;

class Program
{
    static void Main(string[] args)
    {
        LightElementNode node = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);
        node.OuterHTML();
        node.SetState(new ActiveState());
        node.SetState(new DisabledState());
    }
}
