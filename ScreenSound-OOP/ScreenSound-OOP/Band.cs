class Band
{
    public string Name { get; }

    private List<Album> _albumList = new List<Album>();
    public Band(string name)
    {
        this.Name = name;
    }
    
    public void AddAlbum(Album albumName)
    {
        _albumList.Add(albumName);
    }

    public void ShowBandsDiscography()
    {
        Console.WriteLine($"Showing Band's {Name} Discography: ");
        foreach(Album album in _albumList)
        {
            Console.WriteLine($"Album: {album.Name} ({album.TotalDuration})");
        }
        Console.WriteLine("");
    }
}