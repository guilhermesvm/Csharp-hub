using ScreenSound.Models;
using OpenAI_API;

namespace ScreenSound.Menus;

internal class MenuRegisterBand : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        ShowOptionTitles("Band Registration");
        Console.Write("Enter the name of the band you want to register: ");
        string bandName = Console.ReadLine()!;

        Band band = new Band(bandName);
        registeredBands.Add(bandName, band);

        Console.WriteLine($"Band: '{bandName}' has been successfully registered.");
        Console.WriteLine("\nPress any key to return to the main menu.");
        Console.ReadKey();
    }
}
