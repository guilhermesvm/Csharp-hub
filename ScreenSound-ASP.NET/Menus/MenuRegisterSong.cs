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

        Console.Write("Enter the song title: ");
        string songTitle = Console.ReadLine();

        Console.Write("Now, enter the year the song was released: ");
        string input = Console.ReadLine()!;
        if(!int.TryParse(input, out int songYear))
        {
            Console.WriteLine("Invalid input."); 
            return;
        }

        artist.AddSong(new Song(songTitle) 
        { ReleaseYear = songYear});

        repository.Update(artist);

        Console.WriteLine($"The song {songTitle} by {artistName} has been successfully registered!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}
