using ScreenSound_LINQ.Models;

namespace ScreenSound_LINQ.Filters;

internal class LinqFilter
{
    public static void FilterAllMusicGenres(List<Song> songs)
    {
        var allSongGenres = songs
            .Where(song => !string.IsNullOrEmpty(song.Genre))
            .SelectMany(song => song.Genre!.Split(new[] { ',', '/'}, StringSplitOptions.RemoveEmptyEntries))
            .Select(genre => genre.Trim())
            .Distinct().ToList();

        Console.WriteLine($"Available song genres: ");
        foreach (var genre in allSongGenres)
        {
            Console.WriteLine($"- {genre}");
        }
        Console.WriteLine();
    }

    public static void FilterArtistsByGenre(List<Song> songs, string genre)
    {
        var filteredArtists = songs
            .Where(song => !string.IsNullOrEmpty(song.Genre) && song.Genre!.Contains(genre, StringComparison.OrdinalIgnoreCase))
            .Select(song => song.Artist)
            .Distinct().ToList();
      
        Console.WriteLine($"List of artists filtered by genre -> {genre}");
        foreach (var artist in filteredArtists)
        {
            Console.WriteLine($"- {artist}");
        }
        Console.WriteLine();
    }

    public static void FilterSongsByArtist(List<Song> songs, string artist)
    {
        var filteredSongs = songs
            .Where(song => !string.IsNullOrEmpty(song.Artist) && song.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase))
            .Select(song => song.Name)
            .Distinct().ToList();

        Console.WriteLine($"List of songs by {artist}");
        foreach (var song in filteredSongs)
        {
            Console.WriteLine($"- {song}");
        }
        Console.WriteLine();
    }

    public static void FilterSongsByYear(List<Song> songs, string year)
    {
        var filteredSongs = songs
            .Where(song => !string.IsNullOrEmpty(song.Year) && song.Year.Equals(year))
            .Select(song => song.Name)
            .Distinct().ToList();
        
        Console.WriteLine($"List of songs from {year}: ");
        foreach (var song in filteredSongs)
        {
            Console.WriteLine($"- {song}");
        }
        Console.WriteLine();
    }

    public static void FilterSongByKey(List<Song> songs, int key)
    {
        var filteredSongs = songs
            .Where(song => song.IntKey.Equals(key))
            .OrderBy(song => song.Name)
            .Select(song =>  new { song.Name, song.Key })
            .Distinct().ToList();

        Console.WriteLine($"List of songs in key C#: ");
        foreach(var song in filteredSongs)
        {
            Console.WriteLine($"- {song.Name} (Key: {song.Key})");
        }
        Console.WriteLine();
    }
}
