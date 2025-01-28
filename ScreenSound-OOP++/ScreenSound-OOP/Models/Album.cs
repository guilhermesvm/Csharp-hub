namespace ScreenSound.Models;

internal class Album : IRateble
{
    public string Name { get; }

    public static int AlbumCount = 0;
    public int TotalDuration => _musicList.Sum(music => music.Duration);

    public double Average {
        get
        {
            if (_ratingList.Count <= 0) return 0;
            else return _ratingList.Average(a => a.Score);
        }
    }

    private List<Music> _musicList = new List<Music>();
    private List<Rating> _ratingList = new List<Rating>();
    public Album(string name)
    {
        this.Name = name;
        AlbumCount++;
    }

    public void AddMusic(Music music)
    {
        _musicList.Add(music);
    }

    public void AddRating(params Rating[] ratings)
    {
        _ratingList.AddRange(ratings);
    }

    public void ShowAlbumMusics()
    {
        Console.WriteLine($"Music List From {Name}");
        Console.WriteLine($"Total duration: {TotalDuration}");
        foreach(Music music in _musicList)
        {
            Console.WriteLine($"Music: {music.Name}");
        }
        Console.WriteLine();
    }
}