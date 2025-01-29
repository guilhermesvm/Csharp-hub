namespace ScreenSound_LINQ.Models;
using System.Text.Json;

internal class FavoriteSongs
{
    public string? Name { get; set; }

    public List<Song> FavoriteSongsList { get; set; }

    public FavoriteSongs(string name)
    {
        Name = name;
        FavoriteSongsList = new List<Song>();
    }

    public void AddSong(Song song)
    {
        FavoriteSongsList.Add(song);
    }

    public void ShowFavoriteSongs()
    {
        Console.WriteLine($"Favorite songs of {Name}");
        foreach (var song in FavoriteSongsList)
        {
            Console.WriteLine($"- {song.Name} from {song.Artist}");
        }
        Console.WriteLine();
    }

    public void GenerateJSONFile()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            songs = FavoriteSongsList
        }, new JsonSerializerOptions { WriteIndented = true});

        string fileName = $"favorite-songs-{Name}.json";

        File.WriteAllText(fileName, json);
        Console.WriteLine("JSON has been successfully created.");
        Console.WriteLine($"Path: {Path.GetFullPath(fileName)}\n");
    }

    public void GenerateTXTFile()
    {
        string fileName = $"favorite-songs-{Name}.txt";

        using (StreamWriter file = new StreamWriter(fileName))
        {
            file.WriteLine("Guilherme's favorite songs\n");
            foreach(var song in FavoriteSongsList)
            {
                file.WriteLine($"Name: {song.Name}");
                file.WriteLine($"Artist: {song.Artist}");
                file.WriteLine($"Duration: {song.Duration} ms");
                file.WriteLine($"Genre: {song.Genre}");
                file.WriteLine("");
            }
        }
        Console.WriteLine("Txt has been successfully created.");
        Console.WriteLine($"Path: {Path.GetFullPath(fileName)}\n");
    }  
}
