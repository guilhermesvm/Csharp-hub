class Album
{
    public string Name { get; }
    public int TotalDuration => _musicList.Sum(music => music.Duration);
  
    private List<Music> _musicList = new List<Music>();
    public Album(string name)
    {
        this.Name = name;
    }

    public void AddMusic(Music music)
    {
        _musicList.Add(music);
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