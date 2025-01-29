using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuShowBandDetails : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        ShowOptionTitles("Show Band Details");

        Console.Write("Enter the name of the band you want to know more about: ");
        string bandName = Console.ReadLine()!;

        if (!registeredBands.ContainsKey(bandName))
        {
            Console.WriteLine($"\nThe band '{bandName}' was not found!");
            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadKey();
            return;
        }

        double averageRating = registeredBands[bandName].Average;
        if (averageRating == 0)
        {
            Console.WriteLine($"Band {bandName} has not been not rated yet.");
        }
        else Console.WriteLine($"\nThe average rating for the band '{bandName}' is {averageRating:F2}.");

        registeredBands[bandName].ShowBandsDiscography();
        Console.WriteLine("\nPress any key to return to the main menu.");
        Console.ReadKey();
    }
}
