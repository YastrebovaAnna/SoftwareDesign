using Adapter;
using Decorator.Decorators;
using Decorator.HeroBase;
using Decorator;
using System;
using Bridge.Renderers;
using Bridge.Shapes;
using SmartFileReaders;
using LightHTML;
using LightHTML.enums;
using System.Text;
using Flyweight;
using System.Globalization;

class Program
{
    static void Main()
    {
        //Task 6
        ParseHtmlFile(@"..\..\..\..\pg1513.txt");
        DisplayMemoryUsage();
        //Task 1
        PerformLogging(@"..\..\..\..\log.txt");
        //Task 2
        EquipAndDisplayHeroes();
        //Task 3
        DrawShapes();
        //Task 4
        ProcessTextFiles(@"D:\University\KPZ\kpz\lab-3\ConsoleApp\ConsoleApp\sources\sample1.txt",
            @"D:\University\KPZ\kpz\lab-3\ConsoleApp\ConsoleApp\sources\restricted.txt");
        //Task 5
        GenerateHtml();
    }
    static void PerformLogging(string filePath)
    {
        Logger[] loggers = {
            new Logger(),
            new FileLogger(filePath)
        };

        string[] messages = {
            "This is a log message.",
            "This is an error message.",
            "This is a warning message."
        };

        foreach (var logger in loggers)
        {
            logger.Log(messages[0]);
            logger.Error(messages[1]);
            logger.Warn(messages[2]);
        }

        Console.WriteLine("Messages have been logged to the file.");
    }

    static void EquipAndDisplayHeroes()
    {
        var heroes = new (IHero, string, bool, string)[]
        {
            (new Mage(), "Magic Robe", true, "Wand"),
            (new Paladin(), "Magic Coat", true, "Knife"),
            (new Warrior(), "Magic Skirt", false, "Knife")
        };

        foreach (var (baseHero, clothes, amulet, weapon) in heroes)
        {
            IHero equippedHero = new Weapon(new MagicAmulet(new Clothes(baseHero, clothes), amulet), weapon);
            Console.WriteLine(equippedHero.Name);
        }
    }

    static void DrawShapes()
    {
        Shape[] shapes = {
            new Circle(new VectorRenderer()),
            new Square(new RasterRenderer()),
            new Triangle(new VectorRenderer()),
            new Circle(new RasterRenderer())
        };

        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }

    static void ProcessTextFiles(string filePath1, string filePath2)
    {
        ITextReader locker = new SmartTextReaderLocker(
            new SmartTextChecker(new SmartTextReader()),
            @"^restricted.*\.txt$"
        );

        string[] filesToRead = {
            filePath1,
            filePath2
        };

        foreach (string file in filesToRead)
        {
            locker.ReadFile(file);
        }
    }

    static void GenerateHtml()
    {
        var rootElement = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);
        rootElement.AddCssClass("container");

        var paragraph = new LightElementNode("p", DisplayType.Block, ClosingType.Paired);
        paragraph.AddCssClass("text-muted");
        paragraph.AddChild(new LightTextNode("Hi!"));

        rootElement.AddChild(paragraph);

        rootElement.OuterHTML();
        rootElement.InnerHTML();
    }

    static void ParseHtmlFile(string filePath)
    {
        LightElementFactory factory = new LightElementFactory();
        HtmlParser parser = new HtmlParser(factory);

        string[] lines = File.ReadAllLines(filePath);
        LightElementNode htmlTree = parser.ParseBook(lines);

        htmlTree.OuterHTML();
    }

    static void DisplayMemoryUsage()
    {
        long totalMemory = GC.GetTotalMemory(true);
        Console.WriteLine($"\nTotal memory used: {totalMemory} bytes");
    }
}
