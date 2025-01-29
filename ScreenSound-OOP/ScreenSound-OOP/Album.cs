class Album
{
    public string Name { get; }
    public int TotalDuration => _songList.Sum(song => song.Duration);
  
    private List<Song> _songList = new List<Song>();
    public Album(string name)
    {
        this.Name = name;
    }

    public void AddSong(Song song)
    {
        _songList.Add(song);
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