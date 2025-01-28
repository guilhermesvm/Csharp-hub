namespace ScreenSound.Models;
internal class Music
{
    public string Name { get; }
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public string Description => $"Song {Name} belongs to {Artist}";

    public Music(Band artist, string name)
    {
        this.Artist = artist;
        this.Name = name;
    }
    
    public void ShowMusicProperties()
    {
        Console.WriteLine($"Name: {Name}.");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Duration: {Duration}");
        if (!Available)
        {
            Console.WriteLine("Purchase our premium plan.\n");
        }
        else
        {
            Console.WriteLine("Available to listen.\n");
        }       
    }
}