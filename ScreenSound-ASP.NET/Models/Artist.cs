namespace ScreenSound_ASP.NET.Models;

public class Artist
{
    public string Name { get; set; }
    public string ProfilePicture { get; set; }
    public string Bio { get; set; }
    public int Id { get; set; }

    public virtual ICollection<Song> Songs { get; set; } = new List<Song>();

    public Artist(string name, string bio, string? profilePicture = null)
    {
        Name = name;
        Bio = bio;
        ProfilePicture = profilePicture ?? "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png";
    }

    public void AddSong(Song song)
    {
        Songs.Add(song);
    }

    public void DisplayDiscography()
    {
        Console.WriteLine($"Discography of artist {Name}");
        foreach (var song in Songs)
        {
            Console.WriteLine($"Song: {song.Name}");
            Console.WriteLine($"Release Year: {song.ReleaseYear}\n");
        }
    }

    public override string ToString()
    {
        return $@"Id: {Id}
            Name: {Name}
            Profile Picture: {ProfilePicture}
            Bio: {Bio}";
    }
}
