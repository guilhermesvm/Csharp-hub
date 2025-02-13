using ScreenSound_ASP.NET.Models;
using ScreenSound_ASP.NET.Repository;

namespace ScreenSound_ASP.NET.Menus;

internal class MenuRegisterSong : Menu
{
    public override void Execute(GenericRepository<Artist> repository)
    {
        base.Execute(repository);
        DisplayOptionTitle("Song Registration");
        Console.Write("Enter the artist whose song you want to register: ");
        string artistName = Console.ReadLine()!;

        Artist artist = repository.GetBy(a => a.Name.Equals(artistName));
        if (artist == null)
        {
            Console.WriteLine($"\nThe artist {artistName} was not found!");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
            return;
        }

        Console.Write("Now enter the song title: ");
        string songTitle = Console.ReadLine()!;
        artist.AddSong(new Song(songTitle));
        Console.WriteLine($"The song {songTitle} by {artistName} has been successfully registered!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}
