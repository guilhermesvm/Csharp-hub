namespace ScreenSound.Models;

internal class Album : IRateble
{
    public string Name { get; }

    public static int AlbumCount = 0;
    public int TotalDuration => _songList.Sum(song => song.Duration);

    public double Average {
        get
        {
            if (_ratingList.Count <= 0) return 0;
            else return _ratingList.Average(a => a.Score);
        }
    }

    private List<Song> _songList = new List<Song>();
    private List<Rating> _ratingList = new List<Rating>();
    public Album(string name)
    {
        this.Name = name;
        AlbumCount++;
    }

    public void AddSong(Song song)
    {
        _songList.Add(song);
    }

    public void AddRating(params Rating[] ratings)
    {
        _ratingList.AddRange(ratings);
    }

    public void ShowAlbumSongs()
    {
        Console.WriteLine($"Song List From {Name}");
        Console.WriteLine($"Total duration: {TotalDuration}");
        foreach(Song song in _songList)
        {
            Console.WriteLine($"Song: {song.Name}");
        }
        Console.WriteLine();
    }
}