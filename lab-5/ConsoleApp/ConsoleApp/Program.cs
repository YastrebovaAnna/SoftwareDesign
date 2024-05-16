using LightHTML;
using LightHTML.command;
using LightHTML.enums;
using System.Windows.Input;
using ICommand = LightHTML.command.ICommand;

public class Program
{
    public static void Main()
    {
        LightElementNode elementNode = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);

        CommandManager commandManager = new CommandManager();

        Console.WriteLine("Adding a CSS class 'new-class'");
        ICommand addClassCommand = new AddCssClassCommand(elementNode, "new-class");
        commandManager.ExecuteCommand(addClassCommand);
        Console.Write("Current HTML: ");
        elementNode.OuterHTML();
        Console.WriteLine();

        Console.WriteLine("Unadding a CSS class 'new-class'");
        commandManager.Undo();
        Console.Write("Current HTML: ");
        elementNode.OuterHTML();
        Console.WriteLine();

        Console.WriteLine("Adding a CSS class 'another-class'");
        elementNode.AddCssClass("another-class");
        Console.Write("Current HTML: ");
        elementNode.OuterHTML(); 
        Console.WriteLine();

        Console.WriteLine("Removing a CSS class 'another-class'");
        ICommand removeClassCommand = new RemoveCssClassCommand(elementNode, "another-class");
        commandManager.ExecuteCommand(removeClassCommand);
        Console.Write("Current HTML: ");
        elementNode.OuterHTML();
        Console.WriteLine();

        Console.WriteLine("Undoing the removal of a CSS class 'another-class'");
        commandManager.Undo();
        Console.Write("Current HTML: ");
        elementNode.OuterHTML();
        Console.WriteLine();
    }
}