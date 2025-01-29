using System.Text.Json;
using ScreenSound_LINQ.Models;
using ScreenSound_LINQ.Filters;

using (HttpClient client = new HttpClient())
{
    string endpoint = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";

    try
    {
        //Deserializing
        string response = await client.GetStringAsync(endpoint);
        var songs = JsonSerializer.Deserialize<List<Song>>(response)!;
        songs[1].ShowSongDetails();

        LinqFilter.FilterAllMusicGenres(songs);
        LinqOrder.OrderArtistsByName(songs);
        LinqFilter.FilterArtistsByGenre(songs, "rock");
        LinqFilter.FilterSongsByArtist(songs, "blink-182");
        LinqFilter.FilterSongsByYear(songs, "1999");
        LinqFilter.FilterSongByKey(songs, 6);

        //Serializing
        var guilhermesFavoriteSongs = new FavoriteSongs("Guilherme");
        guilhermesFavoriteSongs.AddSong(songs[71]);
        guilhermesFavoriteSongs.ShowFavoriteSongs();
        guilhermesFavoriteSongs.GenerateJSONFile();
        guilhermesFavoriteSongs.GenerateTXTFile();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
