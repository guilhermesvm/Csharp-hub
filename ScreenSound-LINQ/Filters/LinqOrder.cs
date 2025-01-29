using ScreenSound_LINQ.Models;

namespace ScreenSound_LINQ.Filters;

internal class LinqOrder
{
    public static void OrderArtistsByName(List<Song> songs)
    {
        var orderedArtists = songs
            .OrderBy(song => song.Artist)
            .Select(song => song.Artist)
            .Distinct().ToList();
        
        Console.WriteLine("List of artists in Alphabetical Order");
        foreach (var artist in orderedArtists)
        {
            Console.WriteLine(artist);
        }
        Console.WriteLine();
    }
}
