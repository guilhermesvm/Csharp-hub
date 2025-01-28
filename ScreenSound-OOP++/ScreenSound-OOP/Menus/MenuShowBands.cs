using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuShowBands : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        ShowOptionTitles("All Registered Bands");

        foreach (string band in registeredBands.Keys)
        {
            Console.WriteLine($"Band: {band}");
        }
        Console.WriteLine("\nPress any key to return to the menu.");
        Console.ReadKey();
    }
}
