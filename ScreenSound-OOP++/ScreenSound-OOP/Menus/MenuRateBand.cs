using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRateBand : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        ShowOptionTitles("Rate Your Favorite Band!");

        Console.Write("Enter the name of the band you want to rate: ");
        string bandName = Console.ReadLine()!;

        if (!registeredBands.ContainsKey(bandName))
        {
            Console.WriteLine($"\nBand {bandName} was not found.");
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
            return;
        }

        Console.Write($"Enter your rating for {bandName}: ");
        Rating rating = Rating.Parse(Console.ReadLine()!);
        registeredBands[bandName].AddRating(rating);
        Console.WriteLine($"\nYour rating '{rating.Score}' has been successfully registered.");
        Thread.Sleep(2500);
        Console.Clear();
    }
}
