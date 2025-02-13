using ScreenSound_ASP.NET.Models;
using ScreenSound_ASP.NET.Repository;

namespace ScreenSound_ASP.NET.Menus;

internal class MenuShowArtists : Menu
{
    public override void Execute(ArtistRepository artistRepository)
    {
        base.Execute(artistRepository);
        DisplayOptionTitle("Displaying all artists registered in our application");

        foreach (var artist in artistRepository.GetAll())
        {
            Console.WriteLine($"Artist: {artist}");
            Console.WriteLine();
        }

        
        Console.WriteLine("\nPress any key to return to the main menu.");
        Console.ReadKey();
        Console.Clear();
    }
}
