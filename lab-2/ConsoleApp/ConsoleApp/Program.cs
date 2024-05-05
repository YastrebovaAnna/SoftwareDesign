using AuthenticatorLibrary;
using CharacterBuilderLib.Builders;
using CharacterBuilderLib.Services;
using Production_OfEquipment.Factories;
using Production_OfEquipment.Interfaces;
using VideoSubscriptionProject.Factories;
using VideoSubscriptionProject.Subscriptions;
using VirusLibrary;

class Program
{
    static void Main()
    {
        PrintTask("Task 1", ConsoleColor.Magenta);
        HandleSubscriptions();

        PrintTask("Task 2", ConsoleColor.Green);
        HandleDevices();

        PrintTask("Task 3", ConsoleColor.DarkMagenta);
        Authenticator.Instance.Authenticate("Anna");

        PrintTask("Task 4", ConsoleColor.Red);
        HandleVirus();

        PrintTask("Task 5", ConsoleColor.DarkCyan);
        HandleCharacters();
    }
    static void PrintTask(string taskName, ConsoleColor bgColor)
    {
        Console.BackgroundColor = bgColor;
        Console.WriteLine(taskName);
        Console.ResetColor();
    }
    static void HandleSubscriptions()
    {
        var factories = new SubscriptionFactory[] { new WebSite(), new MobileApp(), new ManagerCall() };
        foreach (var factory in factories)
        {
            var subscription = factory.CreateSubscription();
            subscription.DisplayDetails();
        }
    }
    static void HandleDevices()
    {
        var deviceFactories = new IDeviceFactory[] { new IProneFactory(), new KiaomiFactory(), new BalaxyFactory() };
        foreach (var factory in deviceFactories)
        {
            factory.CreateLaptop().ShowInfo();
            factory.CreateSmartphone().ShowInfo();
        }
    }
    static void HandleVirus()
    {
        Virus parentVirus = new Virus(1.0, 5, "AlphaVirus", "AlphaSpecies");
        parentVirus.Children.Add(new Virus(0.5, 2, "BetaVirus", "AlphaSpecies"));
        parentVirus.Children.Add(new Virus(0.3, 1, "GammaVirus", "AlphaSpecies"));
        parentVirus.Children[0].Children.Add(new Virus(0.2, 1, "DeltaVirus", "AlphaSpecies"));

        Virus clonedVirus = (Virus)parentVirus.Clone();

        Console.WriteLine($"Original: {parentVirus.Name}, Children: {parentVirus.Children.Count}");
        Console.WriteLine($"Cloned: {clonedVirus.Name}, Children: {clonedVirus.Children.Count}");
        Console.WriteLine($"Child of Original: {parentVirus.Children[0].Name}, Grandchildren: {parentVirus.Children[0].Children.Count}");
        Console.WriteLine($"Child of Clone: {clonedVirus.Children[0].Name}, Grandchildren: {clonedVirus.Children[0].Children.Count}");
    }
    static void HandleCharacters()
    {
        var director = new Director();
        var hero = director.CreateHero(new HeroBuilder());
        var enemy = director.CreateEnemy(new EnemyBuilder());

        Console.WriteLine("Hero: " + hero);
        Console.WriteLine("Enemy: " + enemy);
    }
}