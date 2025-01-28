using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegisterAlbum : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        ShowOptionTitles("Album Registration");

        Console.Write("Enter the band whose album you want to register: ");
        string bandName = Console.ReadLine()!;
        if (registeredBands.ContainsKey(bandName))
        {
            Console.Write("Now, enter the album title: ");
            string albumTitle = Console.ReadLine()!;
            Band band = registeredBands[bandName];
            band.AddAlbum(new Album(albumTitle));
            Console.WriteLine($"The album {albumTitle} by {bandName} has been successfully registered!");
            Thread.Sleep(2000);    
        } else
        {
            Console.WriteLine($"\nThe band '{bandName}' was not found!");
            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}
