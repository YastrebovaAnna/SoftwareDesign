using CoR.levels;
using CoR;
using AirTrafficControl;
using LightHTML.enums;
using LightHTML;
using Observer.events;
using static System.Net.Mime.MediaTypeNames;
using Strategy;
using Memento;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 1");
        ISupportHandler basic = new BasicSupportHandler();
        ISupportHandler intermediate = new IntermediateSupportHandler();
        ISupportHandler advanced = new AdvancedSupportHandler();
        ISupportHandler expert = new ExpertSupportHandler();

        basic.SetNextHandler(intermediate);
        intermediate.SetNextHandler(advanced);
        advanced.SetNextHandler(expert);

        while (true)
        {
            Console.Write("\nChoose a support level (basic, intermediate, advanced, expert) or type 'exit' to exit:");
            string issue = Console.ReadLine().Trim().ToLower();

            if (issue == "exit")
                break;

            bool handled = basic.HandleRequest(issue);

            if (!handled)
                 Console.WriteLine("No support level has been able to process your request. Try again.");
        }


        
        Console.WriteLine("\n\nTask 2\n");
        Runway[] runways = { new Runway(), new Runway() };
        Aircraft[] aircrafts = { new Aircraft("Boeing 737"), new Aircraft("Airbus A320") };

        CommandCentre commandCentre = new CommandCentre(runways, aircrafts);

        aircrafts[0].Land(commandCentre);
        aircrafts[0].TakeOff(commandCentre);
        aircrafts[1].Land(commandCentre);
        aircrafts[1].TakeOff(commandCentre);

        
        Console.WriteLine("\n\nTask 3\n");
        var divNode = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);
        divNode.AddCssClass("container");
        var textNode = new LightTextNode("Hello, world!");
        divNode.AddChild(textNode);

        var clickObserver = new Click();
        var mouseOverObserver = new Mouseover();

        divNode.AddEventListener(clickObserver);
        divNode.AddEventListener(mouseOverObserver);

        divNode.OuterHTML();
        Console.WriteLine("\nAll events:");
        divNode.NotifyEventListeners();

        divNode.RemoveEventListener(clickObserver);

        Console.WriteLine("Events after remove:");
        divNode.NotifyEventListeners();

        
        Console.WriteLine("\n\nTask 4\n");
        var Img = new Strategy.Image();
        Img.LoadImg("http://google.com/Dog.jpg");
        Img.LoadImg("Dog.png");


        Console.WriteLine("\n\nTask 5\n");
        TextDocument document = new TextDocument("Initial content");
        TextEditor editor = new TextEditor(document);

        Console.WriteLine("Current content: " + editor.GetContent());

        editor.ChangeContent("First change");
        Console.WriteLine("Current content: " + editor.GetContent());

        editor.ChangeContent("Second change");
        Console.WriteLine("Current content: " + editor.GetContent());

        editor.Undo();
        Console.WriteLine("After undo: " + editor.GetContent());

        editor.Undo();
        Console.WriteLine("After second undo: " + editor.GetContent());
    }
}