using System.Text.Json.Serialization;

namespace ScreenSound_LINQ.Models;
internal class Song
{
    [JsonPropertyName("song")]
    public string? Name { get; set; }

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duration { get; set; }

    [JsonPropertyName("year")]
    public string? Year { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    [JsonPropertyName("key")]
    public int IntKey { get; set; }

    public  string Key {
        get
        {
            return keys[IntKey];
        }
    }

    private string[] keys = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    public void ShowSongDetails()
    {
        Console.WriteLine("Song Details:");
        Console.WriteLine($"- Song: {Name}");
        Console.WriteLine($"- Artist: {Artist}");
        Console.WriteLine($"- Duration: {Duration} ms");
        Console.WriteLine($"- Year: {Year}");
        Console.WriteLine($"- Genre: {Genre}");
        Console.WriteLine($"- Key: {Key}");;
        Console.WriteLine();
    }
}
