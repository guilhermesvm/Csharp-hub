using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRateAlbum : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        ShowOptionTitles("Rate Your Favorite Album!");
        Console.Write("Enter the band whose album you want to rate: ");
        string bandName = Console.ReadLine()!;

        if (!registeredBands.ContainsKey(bandName))
        {
            Console.WriteLine($"\nThe band '{bandName}' was not found!");
            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadKey();
            return;
        }
        Band band = registeredBands[bandName];
        Console.Write("Now, enter the album name: ");
        string albumName = Console.ReadLine()!;

        if (!band.Albums.Any(a => a.Name.Equals(albumName)))
        {
            Console.WriteLine($"\nThe album '{albumName}' was not found!");
            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadKey();
            return;
        }
        Album album = band.Albums.First(a => a.Name.Equals(albumName));
        Console.Write($"Enter your rating for {album.Name}: ");
        Rating rating = Rating.Parse(Console.ReadLine()!);

        album.AddRating(rating);
        Console.WriteLine($"\nYour rating '{rating.Score}' to {album.Name} has been successfully registered.");
        Thread.Sleep(2500);
        Console.Clear();
    }
}

