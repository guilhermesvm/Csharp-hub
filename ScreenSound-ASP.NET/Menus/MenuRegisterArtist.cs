using ScreenSound_ASP.NET.Models;
using ScreenSound_ASP.NET.Repository;

namespace ScreenSound_ASP.NET.Menus;

internal class MenuRegisterArtist : Menu
{
    public override void Execute(ArtistRepository artistRepository)
    {
        base.Execute(artistRepository);
        DisplayOptionTitle("Artist Registration");

        Console.Write("Enter the name of the artist you want to register: ");
        string artistName = Console.ReadLine()!;
        Console.Write("Enter the artist's bio: ");
        string artistBio = Console.ReadLine()!;

        Artist artist = new Artist(artistName, artistBio);
        artistRepository.Create(artist);

        Console.WriteLine($"The artist {artistName} has been successfully registered!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}
