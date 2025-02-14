using System.Threading.Channels;
using ScreenSound_ASP.NET.Infrastructure;
using ScreenSound_ASP.NET.Models;
using ScreenSound_ASP.NET.Repository;

namespace ScreenSound_ASP.NET.Menus;

internal class MenuShowSongsByYear : Menu
{
    public override void Execute(GenericRepository<Artist> repository)
    {
        base.Execute(repository);
        DisplayOptionTitle("Display Songs by Release Year");

        Console.Write("Enter the year you want to filter songs by: ");
        string input = Console.ReadLine()!;
        if(!int.TryParse(input, out int year) || year > DateTime.Now.Year)
        {
            Console.WriteLine("Invalid year.");
            Console.WriteLine("\nPress any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
            return;     
        }

        var songRepository = new GenericRepository<Song>(new ScreenSoundContext());

        var filteredSongs = songRepository.GetAllBy(s => s.ReleaseYear.Equals(year));
        if (!filteredSongs.Any())
        {
            Console.WriteLine($"There's no song released in {year}.");
            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadKey();
            Console.Clear();
            return;
        }

        foreach (var song in filteredSongs)
        {
            Console.WriteLine(song);
        }
        Console.WriteLine("\nPress any key to return to the main menu.");
        Console.ReadKey();
        Console.Clear();


    }
}
